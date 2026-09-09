using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Review_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string thresholdFilePath = "thresholds.json";
            string sensorFilePath = "sensors.csv";
            string archiveFilePath = "archive.bin";
            string breachFilePath = "breaches.json";

            try
            {
                // Create threshold data
                List<Thresholds> thresholdList =
                    new List<Thresholds>
                    {
                        new Thresholds("temperature", -10, 45),
                        new Thresholds("humidity", 0, 90),
                        new Thresholds("pressure", 950, 1050)
                    };

                // Create JSON object
                ThresholdConfig config =
                    new ThresholdConfig
                    {
                        Thresholds = thresholdList
                    };

                // Convert threshold data to JSON
                string json =
                    JsonSerializer.Serialize(
                        config,
                        new JsonSerializerOptions
                        {
                            WriteIndented = true
                        });

                // Create/overwrite thresholds.json
                File.WriteAllText(
                    thresholdFilePath,
                    json);

                Console.WriteLine(
                    "thresholds.json created.");

                // Load thresholds from JSON
                ThresholdFile thresholds =
                    new ThresholdFile(
                        thresholdFilePath);

                SensorMonitor monitor =
                    new SensorMonitor(
                        thresholds);

                // Read sensors.csv
                using StreamReader reader =
                    new StreamReader(
                        sensorFilePath);

                // Skip CSV header
                reader.ReadLine();

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        // Convert CSV row into Sensor
                        Sensor sensor =
                            SensorMonitor.ParseReading(
                                line,
                                thresholds);

                        // Process reading
                        monitor.ProcessReading(
                            sensor,
                            sensor.Timestamp.ToString(),
                            sensor.Value.ToString());

                        // Archive valid reading
                        monitor.ArchiveReading(
                            sensor,
                            archiveFilePath);

                        Console.WriteLine(
                            $"Processed: {sensor.SensorId} | " +
                            $"{sensor.Type} | " +
                            $"{sensor.Value}");
                    }
                    catch (SensorException ex)
                    {
                        Console.WriteLine(
                            $"Error: {ex.Message}");
                    }
                }

                // Generate breaches.json
                monitor.WriteBreaches(
                    breachFilePath);

                Console.WriteLine();
                Console.WriteLine(
                    "breaches.json generated.");

                // Display rolling buffer
                Console.WriteLine();
                Console.WriteLine(
                    "Rolling Buffer:");

                foreach (Sensor sensor
                    in monitor.ReadFromRollingBuffer())
                {
                    Console.WriteLine(
                        $"{sensor.SensorId} | " +
                        $"{sensor.Timestamp} | " +
                        $"{sensor.Type} | " +
                        $"{sensor.Value}");
                }

                Console.WriteLine();
                Console.WriteLine(
                    $"Rolling Buffer Count: " +
                    $"{monitor.RollingBufferCount}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(
                    $"File not found: {ex.FileName}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine(
                    $"Invalid JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Unexpected error: {ex.Message}");
            }
        }
    }
}