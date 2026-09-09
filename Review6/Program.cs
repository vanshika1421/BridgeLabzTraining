//Problem — IoT Sensor Threshold & Anomaly Monitor

//Input
//sensors.csv
//SensorId, Timestamp, Type, Value
//SN1,2026-09-01T08:00,temperature,23.5
//SN2,2026-09-01T08:00,humidity,55
//SN3,2026-09-01T08:05,pressure,1012
//SN4,2026-09-01T08:05,voltage,230
//SN1,2026-09-01T08:10,,
//SN2,2026-09-01T08:10,humidity,95
//thresholds.json
//{
//  "thresholds": 
//    { "type": "temperature", "min": -10, "max": 45 },
//    { "type": "humidity", "min": 0, "max": 90 },
//    { "type": "pressure", "min": 950, "max": 1050 }
//  ]
//}Requirements
//Validate sensor type.  done
//Validate timestamp.   
//Validate sensor value.
//Maintain latest 5 readings per sensor.
//Detect 3 consecutive threshold breaches.
//Use MemoryStream as a rolling binary buffer.
//Use BinaryWriter + BinaryReader.
//Generate breaches.json.
//Archive every reading using BufferedStream.
//ExceptionsSensorException
// ├── UnknownSensorTypeException
// ├── InvalidSensorValueException
// └── InvalidTimestampException
// NUnit Testing — Minimum 8 Tests
//Test:
//Reading within threshold.
//Value exactly at minimum boundary.
//Value exactly at maximum boundary.
//Value below minimum.
//Value above maximum.
//Unknown sensor type.
//Invalid timestamp.
//Blank/non-numeric sensor value.
//Three consecutive breaches trigger anomaly.
//Two breaches do not trigger anomaly.
//Rolling window retains only latest five records.
//Binary rolling-buffer round-trip.

//thresholds.json
//{
//  "thresholds": 
//    { "type": "temperature", "min": -10, "max": 45 },
//    { "type": "humidity", "min": 0, "max": 90 },
//    { "type": "pressure", "min": 950, "max": 1050 }
//  ]


using System.Text.Json;
using System;
using System.Collections.Generic;

namespace Review_6;
public class Program
{
    public static async Task Main(string[] args)
    {
        List<Sensor> sensors = new List<Sensor>();
        Sensor s = new Sensor
        {
            SensorId = 1,
            Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
            Type = "Temperature",
            Value = 23.5f
        };
        Sensor s1 = new Sensor
        {
            SensorId = 2,
            Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
            Type = "Humidity",
            Value = 23.5f
        };
        sensors.Add(s1);
        Sensor s2 = new Sensor
        {
            SensorId = 3,
            Timestamp = new DateTime(2026, 9, 1, 8, 0, 5),
            Type = "Temperature",
            Value = 23.5f
        };
        sensors.Add(s2);
        Sensor s3 = new Sensor
        {
            SensorId = 4,
            Timestamp = new DateTime(2026, 9, 1, 8, 0, 5),
            Type = "Pressure",
            Value = 23.5f
        };
        Sensor s32 = new Sensor
        {
            SensorId = 4,
            Timestamp = new DateTime(2026, 9, 1, 8, 0, 5),
            Type = "Pressure",
            Value = 950f
        };
        sensors.Add(s32);
        Sensor s33 = new Sensor
        {
            SensorId = 4,
            Timestamp = new DateTime(2026, 9, 1, 8, 0, 5),
            Type = "Pressure",
            Value = 1020
        };
        sensors.Add(s33);
        sensors.Add(s3);
        Sensor s4 = new Sensor
        {
            SensorId = 1,
            Timestamp = new DateTime(2026, 9, 1, 8, 1, 0),
            Type = "Temperature",
            Value = 23.5f
        };
        sensors.Add(s4);
        Sensor s5 = new Sensor
        {
            SensorId = 1,
            Timestamp = new DateTime(2026, 9, 1, 8, 1, 0),
            Type = "Temperature",
            Value = 23.5f
        };
        sensors.Add(s5);

        foreach(Sensor sensor in sensors)
        {
            Console.WriteLine(sensor.SensorId);    
        }
        Sensor senser = new Sensor();
        Console.WriteLine("Enter the type of sensor to validate");
        string type = Console.ReadLine();
        Console.WriteLine(senser.ValidSensors_Type(sensors, type));
        MemoryStream ms = new MemoryStream();
        Thresholds thresholds = new Thresholds();
        
       
        List<Thresholds> list = new List<Thresholds>();
        Thresholds thres = new Thresholds
        {
            Type = "Temperature",
            min = -10,
            max = 45
        };
        list.Add(thres);
        Thresholds t1 = new Thresholds
        {
            Type = "Humidity",
            min = 0,
            max = 90
        };
        list.Add(t1);
        Thresholds t2 = new Thresholds
        {
            Type = "Pressure",
            min = 0,
            max = 90
        };
        list.Add(t2);
        string json = JsonSerializer.Serialize(thres );
        File.WriteAllText("threshold.json", json);
        string json2 = JsonSerializer.Serialize(t1);
        File.AppendAllText("threshold.json", json2);
        string json3 = JsonSerializer.Serialize(t2);
        File.AppendAllText("threshold.json", json3);
        Console.WriteLine("Enter the sensor to be checked");
        Console.WriteLine("s1\ns2\ns3\ns4\ns5");
      
        Console.WriteLine (thresholds.Validate_sensor_Value(list, s5));

    }
}