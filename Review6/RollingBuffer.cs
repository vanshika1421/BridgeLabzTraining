using System;
using System.Collections.Generic;
using System.IO;

namespace Review_6
{
    public class RollingBuffer
    {
        private readonly MemoryStream stream;
        private readonly BinaryWriter writer;
        private readonly BinaryReader reader;

        public RollingBuffer()
        {
            stream = new MemoryStream();
            writer = new BinaryWriter(stream);
            reader = new BinaryReader(stream);
        }

        // Write readings into the memory stream
        public void WriteReadings(IEnumerable<Sensor> readings)
        {
            stream.SetLength(0);
            stream.Position = 0;

            foreach (Sensor sensor in readings)
            {
                writer.Write(sensor.SensorId);
                writer.Write(sensor.Timestamp.ToBinary());
                writer.Write(sensor.Type);
                writer.Write(sensor.Value);
            }

            writer.Flush();
        }

        // Read readings from the memory stream
        public List<Sensor> ReadReadings()
        {
            List<Sensor> readings = new List<Sensor>();

            stream.Position = 0;

            while (stream.Position < stream.Length)
            {
                string sensorId = reader.ReadString();

                DateTime timestamp =
                    DateTime.FromBinary(reader.ReadInt64());

                string type = reader.ReadString();

                double value = reader.ReadDouble();

                readings.Add(
                    new Sensor(
                        sensorId,
                        timestamp,
                        type,
                        value));
            }

            return readings;
        }

        public int Count
        {
            get
            {
                return ReadReadings().Count;
            }
        }
    }
}