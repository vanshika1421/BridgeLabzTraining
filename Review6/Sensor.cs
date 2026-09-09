using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;
using System.IO;

namespace Review_6
{
    public class Sensor
    {
        //SensorId, Timestamp, Type, Value
        public int SensorId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Type { get; set; }
        public float Value { get; set; }

        // instance streams/writers declared at class level
        private MemoryStream stream;
        private BinaryWriter writer;
        private BinaryReader reader;

        // CREATE sensor.csv using stream
        //public void helper()
        //{
        //    stream = new MemoryStream();
        //    writer = new BinaryWriter(stream);
        //    File.WriteAllText("sensor.csv" ,string.Empty );
        //    writer.Write("SensorId,TimeStamp,Type,Value");
      
            

        //}

        public Sensor()
        {
            stream = new MemoryStream();
            writer = new BinaryWriter(stream);
            File.WriteAllText("sensor.csv", string.Empty);
            writer.Write("SensorId,TimeStamp,Type,Value");
            writer.Flush();
        }

        public Sensor(int sensorId, DateTime timestamp, string type, float value)
        {
            SensorId = sensorId;
            Timestamp = timestamp;
            Type = type;
            Value = value;

            //stream = new MemoryStream();
            //writer = new BinaryWriter(stream);
            //reader = new BinaryReader(stream);
        }

        public bool ValidSensors_Type(List<Sensor> sensors , string Type)
        {
            foreach (Sensor sensor in sensors)
            {
                if(sensor.Type == Type)
                {
                    return true;
                }
            }
            return false;
        }
        

    }
}
