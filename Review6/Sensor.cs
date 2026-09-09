using System;
using System.Collections.Generic;

namespace Review_6
{
    public class Sensor
    {
        public string SensorId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }

        private readonly Dictionary<string, Queue<Sensor>> latestReadings =
            new Dictionary<string, Queue<Sensor>>();

        public Sensor()
        {
        }

        public Sensor(
            string sensorId,
            DateTime timestamp,
            string type,
            double value)
        {
            SensorId = sensorId;
            Timestamp = timestamp;
            Type = type;
            Value = value;
        }

        // Validate sensor type
        public bool ValidSensors_Type(
            List<Sensor> sensors,
            string type)
        {
            foreach (Sensor sensor in sensors)
            {
                if (sensor.Type.Equals(
                    type,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        // Validate timestamp
        public bool ValidateTimestamp(string timestamp)
        {
            if (string.IsNullOrWhiteSpace(timestamp))
            {
                return false;
            }

            return DateTime.TryParse(timestamp, out _);
        }

        // Validate sensor value
        public bool ValidateValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            return double.TryParse(value, out _);
        }

        // Maintain latest 5 readings per sensor
        public void AddReading(Sensor sensor)
        {
            if (!latestReadings.ContainsKey(sensor.SensorId))
            {
                latestReadings[sensor.SensorId] =
                    new Queue<Sensor>();
            }

            Queue<Sensor> readings =
                latestReadings[sensor.SensorId];

            readings.Enqueue(sensor);

            if (readings.Count > 5)
            {
                readings.Dequeue();
            }
        }

        // Get latest readings for a sensor
        public Queue<Sensor> GetReadings(string sensorId)
        {
            if (latestReadings.ContainsKey(sensorId))
            {
                return latestReadings[sensorId];
            }

            return new Queue<Sensor>();
        }
    }
}