# IoT Sensor Threshold & Anomaly Monitor

## Overview

The IoT Sensor Threshold & Anomaly Monitor is a C# console application that processes IoT sensor readings from a CSV file.

The application validates sensor data, checks readings against configured thresholds, maintains the latest five readings for each sensor, detects consecutive threshold breaches, stores readings in a binary rolling buffer, archives readings, and generates a JSON breach report.

The project demonstrates practical use of C# file handling, streams, JSON serialization, collections, custom exceptions, and NUnit testing.



## Objectives

The main objectives of this project are:

- Read sensor data from a CSV file.
- Validate sensor types.
- Validate timestamps.
- Validate sensor values.
- Compare sensor readings against configured thresholds.
- Maintain the latest five readings for each sensor.
- Detect three consecutive threshold breaches.
- Use `MemoryStream` as a rolling binary buffer.
- Use `BinaryWriter` and `BinaryReader`.
- Archive sensor readings using `BufferedStream`.
- Generate a `breaches.json` report.
- Handle invalid input using custom exceptions.
- Test the implementation using NUnit.

---

## Technologies Used

- C#
- .NET
- NUnit
- `System.IO`
- `System.Text.Json`
- `MemoryStream`
- `BinaryWriter`
- `BinaryReader`
- `BufferedStream`
- `Queue<T>`
- `Dictionary<TKey, TValue>`

---

## Project Structure

```text
Review_6/
│
├── Program.cs
├── Sensor.cs
├── Thresholds.cs
├── ThresholdFile.cs
├── SensorMonitor.cs
├── RollingBuffer.cs
├── BreachRecord.cs
├── CustomException.cs
├── SensorMonitorTests.cs
│
└── sensors.csv
The following files are generated automatically when the program runs:
thresholds.json
breaches.json
archive.bin
Input File
sensors.csv
The application reads sensor readings from sensors.csv.
Example:
SensorId,Timestamp,Type,Value
SN1,2026-09-01T08:00,temperature,23.5
SN2,2026-09-01T08:00,humidity,55
SN3,2026-09-01T08:05,pressure,1012
SN4,2026-09-01T08:05,voltage,230
SN1,2026-09-01T08:10,,
Each row contains four fields:
SensorId
Timestamp
Type
Value
Invalid rows are handled using custom exceptions.
Threshold Configuration
The program creates thresholds.json automatically.
The threshold configuration contains the minimum and maximum allowed values for each supported sensor type.
Example:
{
  "thresholds": [
    {
      "type": "temperature",
      "min": -10,
      "max": 45
    },
    {
      "type": "humidity",
      "min": 0,
      "max": 90
    },
    {
      "type": "pressure",
      "min": 950,
      "max": 1050
    }
  ]
}
Threshold Rules
A value is considered valid when it is between the minimum and maximum values, including the boundaries.
For example:
Temperature = -10  → Valid
Temperature = 45   → Valid
Temperature = -11  → Breach
Temperature = 46   → Breach
Validation
The application performs validation before processing sensor readings.
1. Sensor Type Validation
The sensor type must exist in the threshold configuration.
Supported types:
temperature
humidity
pressure
For example:
temperature → Valid
humidity    → Valid
pressure    → Valid
voltage     → Invalid
An UnknownSensorTypeException is thrown when an unknown sensor type is encountered.
2. Timestamp Validation
The timestamp must be a valid date and time.
Example of a valid timestamp:
2026-09-01T08:00
An InvalidTimestampException is thrown when the timestamp is invalid or blank.
3. Sensor Value Validation
The sensor value must not be blank and must contain a valid numeric value.
Examples:
23.5 → Valid
55   → Valid
""   → Invalid
abc  → Invalid
An InvalidSensorValueException is thrown for blank or non-numeric values.
Latest Five Readings
The application maintains only the latest five readings for each sensor.
A Queue<Sensor> is used to implement the rolling window.
For example, if a sensor receives six readings:
Reading 1
Reading 2
Reading 3
Reading 4
Reading 5
Reading 6
only the latest five are retained:
Reading 2
Reading 3
Reading 4
Reading 5
Reading 6
When a sixth reading is added, the oldest reading is removed.
This behavior is maintained separately for each sensor.
Threshold Breach Detection
A threshold breach occurs when a sensor value is outside its configured range.
For example, if the temperature range is:
Minimum = -10
Maximum = 45
then:
46 → Breach
50 → Breach
52 → Breach
The application tracks consecutive breaches separately for each sensor.
Three Consecutive Breaches
An anomaly is detected when the same sensor produces three consecutive threshold breaches.
Example:
SN1 → 50 → Breach 1
SN1 → 51 → Breach 2
SN1 → 52 → Breach 3
The third reading is marked as an anomaly.
If a normal reading occurs, the consecutive breach count is reset.
Example:
SN1 → 50 → Breach 1
SN1 → 51 → Breach 2
SN1 → 30 → Normal
The counter is reset after the normal reading.
Custom Exceptions
The project uses a custom exception hierarchy for handling invalid sensor data.
SensorException
│
├── UnknownSensorTypeException
├── InvalidSensorValueException
└── InvalidTimestampException
SensorException
Base exception for sensor-related errors.
UnknownSensorTypeException
Thrown when the sensor type is not present in the threshold configuration.
InvalidSensorValueException
Thrown when the sensor value is blank or non-numeric.
InvalidTimestampException
Thrown when the timestamp is invalid or blank.
MemoryStream Rolling Buffer
The application uses MemoryStream as a binary rolling buffer.
Each sensor reading is written using BinaryWriter.
The following information is stored:
SensorId
Timestamp
Type
Value
The data is then read back using BinaryReader.
The process is:
Sensor Reading
      ↓
BinaryWriter
      ↓
MemoryStream
      ↓
BinaryReader
      ↓
Sensor Object
This demonstrates binary writing and reading using C# streams.
BinaryWriter and BinaryReader
BinaryWriter is used to write sensor information in binary format.
Example data written:
SensorId
Timestamp
Type
Value
BinaryReader reads the same data and reconstructs the sensor object.
The binary rolling buffer is tested using a round-trip test to ensure that the written data can be correctly read back.
BufferedStream Archiving
Every valid sensor reading is archived in:
archive.bin
The application uses:
FileStream
    ↓
BufferedStream
    ↓
BinaryWriter
BufferedStream provides buffering while writing the binary archive.
The archived information includes:
SensorId
Timestamp
Type
Value
Breach Report
The application generates:
breaches.json
This file contains information about threshold breaches.
Each breach record contains:
SensorId
Timestamp
Type
Value
Anomaly
Example:
[
  {
    "SensorId": "SN1",
    "Timestamp": "2026-09-01T08:00:00",
    "Type": "temperature",
    "Value": 50,
    "Anomaly": false
  }
]
When three consecutive breaches occur, the corresponding record is marked:
"Anomaly": true
Application Workflow
The overall workflow of the application is:
              sensors.csv
                   ↓
              Read CSV Row
                   ↓
            Validate Timestamp
                   ↓
            Validate Sensor Type
                   ↓
            Validate Sensor Value
                   ↓
          Check Threshold Range
                   ↓
       Maintain Latest 5 Readings
                   ↓
      Check Consecutive Breaches
                   ↓
        Store in MemoryStream
                   ↓
       Archive Using BufferedStream
                   ↓
          Generate breaches.json
Main Classes
Program
Program.cs is the entry point of the application.
Responsibilities:
- Create threshold configuration.
- Generate thresholds.json.
- Load threshold information.
- Read sensors.csv.
- Process sensor readings.
- Archive valid readings.
- Generate breaches.json.
- Display rolling-buffer contents.
Sensor
Sensor.cs represents an individual sensor reading.
Properties:
SensorId
Timestamp
Type
Value
It also contains basic validation and reading-management functionality.
Thresholds
Thresholds.cs represents the threshold configuration for a sensor type.
Properties:
Type
Min
Max
It provides functionality for checking whether a sensor value is inside its configured threshold.
ThresholdFile
ThresholdFile.cs handles loading and validating threshold configuration from JSON.
Responsibilities:
- Read thresholds.json.
- Validate sensor types.
- Validate raw sensor values.
- Check sensor values against thresholds.
- Provide threshold information to the monitor.
SensorMonitor
SensorMonitor.cs is the main processing class.
Responsibilities:
- Process sensor readings.
- Validate input.
- Maintain latest five readings.
- Track consecutive threshold breaches.
- Detect anomalies.
- Maintain the rolling binary buffer.
- Generate breaches.json.
- Archive readings.
RollingBuffer
RollingBuffer.cs manages the MemoryStream.
It uses:
MemoryStream
BinaryWriter
BinaryReader
to write and read sensor data in binary format.
BreachRecord
BreachRecord.cs represents a threshold breach.
Properties:
SensorId
Timestamp
Type
Value
Anomaly
CustomException
CustomException.cs contains the custom exception hierarchy used for sensor validation errors.
Testing
The project uses NUnit for unit testing.
The tests cover the major functional requirements.
Test Cases
1. Reading within threshold
2. Value exactly at minimum boundary
3. Value exactly at maximum boundary
4. Value below minimum
5. Value above maximum
6. Unknown sensor type
7. Invalid timestamp
8. Blank sensor value
9. Non-numeric sensor value
10. Three consecutive breaches trigger anomaly
11. Two consecutive breaches do not trigger anomaly
12. Rolling window retains latest five readings
13. Binary rolling-buffer round trip
The project therefore contains more than the required minimum of eight tests.
How to Run the Project
Step 1
Open the project in Visual Studio.
Step 2
Make sure sensors.csv is present in the project.
If required, set:
Copy to Output Directory → Copy if newer
for sensors.csv.
Step 3
Build the project.
Step 4
Run the application.
The application will:
1. Create thresholds.json.
2. Read sensors.csv.
3. Validate sensor readings.
4. Check threshold breaches.
5. Maintain the latest five readings.
6. Detect consecutive breaches.
7. Store readings in the binary rolling buffer.
8. Archive valid readings.
9. Generate breaches.json.
Generated Files
After running the application, the following files are generated:
thresholds.json
Contains sensor threshold configuration.
breaches.json
Contains detected threshold breaches and anomaly information.
archive.bin
Contains archived sensor readings in binary format.
Example
For a temperature threshold:
Minimum = -10
Maximum = 45
Consider the following readings:
23.5
46
47
48
The first reading is within the threshold.
The next three readings are breaches:
46 → Breach 1
47 → Breach 2
48 → Breach 3 → Anomaly
The third consecutive breach is therefore marked as an anomaly.
Error Handling
Invalid sensor readings are handled without stopping the complete application.
For example, if one CSV row contains an unknown sensor type:
SN4,2026-09-01T08:05,voltage,230
the application throws:
UnknownSensorTypeException
The error is displayed and the application continues processing the remaining rows.
This allows valid sensor readings to continue being processed even when individual rows contain invalid data.
Conclusion
The IoT Sensor Threshold & Anomaly Monitor demonstrates how C# can be used to build a small data-processing application using file handling, JSON serialization, collections, streams, binary data processing, custom exceptions, and unit testing.
The project combines these concepts into a single workflow for validating sensor readings, tracking sensor history, identifying abnormal behavior, and generating reports.
