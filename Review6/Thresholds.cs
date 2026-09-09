using System;
using System.Collections.Generic;

namespace Review_6
{
    public class Thresholds
    {
        public string Type { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }

        public Thresholds()
        {
        }

        public Thresholds(
            string type,
            double min,
            double max)
        {
            Type = type;
            Min = min;
            Max = max;
        }

        // Validate whether the sensor value is within its threshold
        public bool Validate_sensor_Value(
            List<Thresholds> list,
            Sensor sensor)
        {
            foreach (Thresholds threshold in list)
            {
                if (threshold.Type.Equals(
                    sensor.Type,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return sensor.Value >= threshold.Min &&
                           sensor.Value <= threshold.Max;
                }
            }

            return false;
        }

        // Find threshold for a particular sensor type
        public Thresholds GetThreshold(
            List<Thresholds> list,
            string sensorType)
        {
            foreach (Thresholds threshold in list)
            {
                if (threshold.Type.Equals(
                    sensorType,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return threshold;
                }
            }

            return null;
        }
    }
}