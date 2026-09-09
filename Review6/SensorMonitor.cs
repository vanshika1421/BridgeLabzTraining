using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Review_6
{
    public class SensorMonitor
    {
        private readonly ThresholdFile thresholds;

        // Latest 5 readings for each sensor
        private readonly Dictionary<string, Queue<Sensor>> readings =
            new Dictionary<string, Queue<Sensor>>();

        // Consecutive breach count for each sensor
        private readonly Dictionary<string, int> consecutiveBreaches =
            new Dictionary<string, int>();

        // All breach records
        private readonly List<BreachRecord> breaches =
            new List<BreachRecord>();

        // Binary rolling buffer
        private readonly RollingBuffer rollingBuffer =
            new RollingBuffer();

        public SensorMonitor(ThresholdFile thresholds)
        {
            this.thresholds = thresholds;
        }

        // Process one sensor reading
        public void ProcessReading(
            Sensor sensor,
            string rawTimestamp,
            string rawValue)
        {
            // 1. Validate timestamp
            DateTime timestamp = ValidateTimestamp(rawTimestamp);

            sensor.Timestamp = timestamp;

            // 2. Validate sensor type
            thresholds.ValidateType(sensor.Type);

            // 3. Validate sensor value
            thresholds.ValidateValue(
                rawValue,
                sensor.Type);

            // 4. Convert value
            sensor.Value = double.Parse(rawValue);

            // 5. Add to latest-five readings
            AddReading(sensor);

            // 6. Check threshold
            bool breach =
                !thresholds.IsWithinThreshold(sensor);

            // Initialize breach counter
            if (!consecutiveBreaches.ContainsKey(
                sensor.SensorId))
            {
                consecutiveBreaches[sensor.SensorId] = 0;
            }

            if (breach)
            {
                consecutiveBreaches[sensor.SensorId]++;

                bool anomaly =
                    consecutiveBreaches[sensor.SensorId] >= 3;

                breaches.Add(
                    new BreachRecord
                    {
                        SensorId = sensor.SensorId,
                        Timestamp = sensor.Timestamp,
                        Type = sensor.Type,
                        Value = sensor.Value,
                        Anomaly = anomaly
                    });
            }
            else
            {
                // A valid reading breaks the consecutive sequence
                consecutiveBreaches[sensor.SensorId] = 0;
            }
        }

        // Maintain latest 5 readings per sensor
        public void AddReading(Sensor sensor)
        {
            if (!readings.ContainsKey(sensor.SensorId))
            {
                readings[sensor.SensorId] =
                    new Queue<Sensor>();
            }

            Queue<Sensor> sensorReadings =
                readings[sensor.SensorId];

            sensorReadings.Enqueue(sensor);

            // Keep only latest 5
            while (sensorReadings.Count > 5)
            {
                sensorReadings.Dequeue();
            }

            // Update rolling binary buffer
            rollingBuffer.WriteReadings(
                readings.SelectMany(x => x.Value));
        }

        // Get latest readings for one sensor
        public List<Sensor> GetLatestReadings(
            string sensorId)
        {
            if (!readings.ContainsKey(sensorId))
            {
                return new List<Sensor>();
            }

            return readings[sensorId].ToList();
        }

        // Check whether sensor has reached 3 consecutive breaches
        public bool HasThreeConsecutiveBreaches(
            string sensorId)
        {
            return consecutiveBreaches.TryGetValue(
                       sensorId,
                       out int count)
                   && count >= 3;
        }

        // Read data from MemoryStream
        public List<Sensor> ReadFromRollingBuffer()
        {
            return rollingBuffer.ReadReadings();
        }

        public int RollingBufferCount
        {
            get
            {
                return rollingBuffer.Count;
            }
        }

        // Generate breaches.json
        public void WriteBreaches(string filePath)
        {
            string json =
                JsonSerializer.Serialize(
                    breaches,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

            File.WriteAllText(
                filePath,
                json);
        }

        // Archive every reading using BufferedStream
        public void ArchiveReading(
            Sensor sensor,
            string filePath)
        {
            using FileStream fileStream =
                new FileStream(
                    filePath,
                    FileMode.Append,
                    FileAccess.Write,
                    FileShare.Read);

            using BufferedStream bufferedStream =
                new BufferedStream(fileStream);

            using BinaryWriter writer =
                new BinaryWriter(bufferedStream);

            writer.Write(sensor.SensorId);
            writer.Write(sensor.Timestamp.ToBinary());
            writer.Write(sensor.Type);
            writer.Write(sensor.Value);
        }

        // Validate timestamp
        public static DateTime ValidateTimestamp(
            string value)
        {
            if (string.IsNullOrWhiteSpace(value) ||
                !DateTime.TryParse(
                    value,
                    out DateTime timestamp))
            {
                throw new InvalidTimestampException(
                    $"Invalid timestamp: {value}");
            }

            return timestamp;
        }

        // Parse one CSV row
        public static Sensor ParseReading(
            string line,
            ThresholdFile thresholds)
        {
            string[] parts =
                line.Split(',');

            if (parts.Length != 4)
            {
                throw new InvalidSensorValueException(
                    "Invalid sensor CSV row.");
            }

            string sensorId =
                parts[0].Trim();

            string rawTimestamp =
                parts[1].Trim();

            string type =
                parts[2].Trim();

            string rawValue =
                parts[3].Trim();

            if (string.IsNullOrWhiteSpace(sensorId))
            {
                throw new InvalidSensorValueException(
                    "Sensor ID cannot be blank.");
            }

            DateTime timestamp =
                ValidateTimestamp(rawTimestamp);

            thresholds.ValidateType(type);

            thresholds.ValidateValue(
                rawValue,
                type);

            if (!double.TryParse(
                rawValue,
                out double value))
            {
                throw new InvalidSensorValueException(
                    $"Invalid sensor value: {rawValue}");
            }

            return new Sensor(
                sensorId,
                timestamp,
                type,
                value);
        }
    }
}