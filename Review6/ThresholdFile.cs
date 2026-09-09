using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Review_6
{
    public class ThresholdFile
    {
        private readonly List<Thresholds> thresholds;


        public ThresholdFile(string filePath)
        {
            string json = File.ReadAllText(filePath);

            ThresholdConfig config =
                JsonSerializer.Deserialize<ThresholdConfig>(
                    json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

            thresholds = config?.Thresholds
                ?? new List<Thresholds>();
        }

        // Validate sensor type
        public void ValidateType(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new UnknownSensorTypeException(
                    "Sensor type cannot be blank.");
            }

            bool exists = thresholds.Exists(
                t => t.Type.Equals(
                    type,
                    StringComparison.OrdinalIgnoreCase));

            if (!exists)
            {
                throw new UnknownSensorTypeException(
                    $"Unknown sensor type: {type}");
            }
        }

        // Validate raw sensor value
        public void ValidateValue(
            string rawValue,
            string sensorType)
        {
            if (string.IsNullOrWhiteSpace(rawValue))
            {
                throw new InvalidSensorValueException(
                    $"Sensor value is blank for type: {sensorType}");
            }

            if (!double.TryParse(
                rawValue,
                out _))
            {
                throw new InvalidSensorValueException(
                    $"Invalid sensor value: {rawValue}");
            }
        }

        // Check whether value is within threshold
        public bool IsWithinThreshold(Sensor sensor)
        {
            Thresholds threshold = thresholds.Find(
                t => t.Type.Equals(
                    sensor.Type,
                    StringComparison.OrdinalIgnoreCase));

            if (threshold == null)
            {
                throw new UnknownSensorTypeException(
                    $"Unknown sensor type: {sensor.Type}");
            }

            return sensor.Value >= threshold.Min &&
                   sensor.Value <= threshold.Max;
        }

        // Get all thresholds
        public List<Thresholds> GetThresholds()
        {
            return thresholds;
        }
    }

    // Represents the structure of thresholds.json
    public class ThresholdConfig
    {
        public List<Thresholds> Thresholds { get; set; }
    }
}