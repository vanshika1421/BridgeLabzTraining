
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace Review_6.Tests
{
    [TestFixture]
    public class SensorMonitorTests
    {
        private string thresholdFilePath;
        private ThresholdFile thresholds;
        private SensorMonitor monitor;

        [SetUp]
        public void Setup()
        {
            thresholdFilePath = "test-thresholds.json";

            string json = """
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
            """;

            File.WriteAllText(thresholdFilePath, json);

            thresholds = new ThresholdFile(thresholdFilePath);
            monitor = new SensorMonitor(thresholds);
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(thresholdFilePath))
            {
                File.Delete(thresholdFilePath);
            }
        }

        // 1. Reading within threshold
        [Test]
        public void ReadingWithinThreshold_ShouldNotBeBreach()
        {
            Sensor sensor = new Sensor(
                "SN1",
                new DateTime(2026, 9, 1, 8, 0, 0),
                "temperature",
                23.5);

            Assert.DoesNotThrow(() =>
                monitor.ProcessReading(
                    sensor,
                    "2026-09-01T08:00",
                    "23.5"));

            Assert.That(
                monitor.HasThreeConsecutiveBreaches("SN1"),
                Is.False);
        }

        // 2. Value exactly at minimum boundary
        [Test]
        public void ValueAtMinimumBoundary_ShouldBeValid()
        {
            Sensor sensor = new Sensor(
                "SN1",
                DateTime.Now,
                "temperature",
                -10);

            Assert.DoesNotThrow(() =>
                monitor.ProcessReading(
                    sensor,
                    "2026-09-01T08:00",
                    "-10"));

            Assert.That(
                monitor.HasThreeConsecutiveBreaches("SN1"),
                Is.False);
        }

        // 3. Value exactly at maximum boundary
        [Test]
        public void ValueAtMaximumBoundary_ShouldBeValid()
        {
            Sensor sensor = new Sensor(
                "SN1",
                DateTime.Now,
                "temperature",
                45);

            Assert.DoesNotThrow(() =>
                monitor.ProcessReading(
                    sensor,
                    "2026-09-01T08:00",
                    "45"));

            Assert.That(
                monitor.HasThreeConsecutiveBreaches("SN1"),
                Is.False);
        }

        // 4. Value below minimum
        [Test]
        public void ValueBelowMinimum_ShouldBeBreach()
        {
            Sensor sensor = new Sensor(
                "SN1",
                DateTime.Now,
                "temperature",
                -11);

            Assert.DoesNotThrow(() =>
                monitor.ProcessReading(
                    sensor,
                    "2026-09-01T08:00",
                    "-11"));

            Assert.That(
                monitor.HasThreeConsecutiveBreaches("SN1"),
                Is.False);
        }

        // 5. Value above maximum
        [Test]
        public void ValueAboveMaximum_ShouldBeBreach()
        {
            Sensor sensor = new Sensor(
                "SN1",
                DateTime.Now,
                "temperature",
                46);

            Assert.DoesNotThrow(() =>
                monitor.ProcessReading(
                    sensor,
                    "2026-09-01T08:00",
                    "46"));

            Assert.That(
                monitor.HasThreeConsecutiveBreaches("SN1"),
                Is.False);
        }

        // 6. Unknown sensor type
        [Test]
        public void UnknownSensorType_ShouldThrowException()
        {
            Sensor sensor = new Sensor(
                "SN1",
                DateTime.Now,
                "voltage",
                230);

            Assert.Throws<UnknownSensorTypeException>(() =>
                monitor.ProcessReading(
                    sensor,
                    "2026-09-01T08:00",
                    "230"));
        }

        // 7. Invalid timestamp
        [Test]
        public void InvalidTimestamp_ShouldThrowException()
        {
            Sensor sensor = new Sensor(
                "SN1",
                DateTime.Now,
                "temperature",
                23.5);

            Assert.Throws<InvalidTimestampException>(() =>
                monitor.ProcessReading(
                    sensor,
                    "invalid-date",
                    "23.5"));
        }

        // 8. Blank / non-numeric sensor value
        [Test]
        public void BlankSensorValue_ShouldThrowException()
        {
            Sensor sensor = new Sensor(
                "SN1",
                DateTime.Now,
                "temperature",
                0);

            Assert.Throws<InvalidSensorValueException>(() =>
                monitor.ProcessReading(
                    sensor,
                    "2026-09-01T08:00",
                    ""));
        }

        [Test]
        public void NonNumericSensorValue_ShouldThrowException()
        {
            Sensor sensor = new Sensor(
                "SN1",
                DateTime.Now,
                "temperature",
                0);

            Assert.Throws<InvalidSensorValueException>(() =>
                monitor.ProcessReading(
                    sensor,
                    "2026-09-01T08:00",
                    "abc"));
        }

        [Test]
        public void ThreeConsecutiveBreaches_ShouldTriggerAnomaly()
        {
            monitor.ProcessReading(
                new Sensor(
                    "SN1",
                    DateTime.Now,
                    "temperature",
                    50),
                "2026-09-01T08:00",
                "50");

            monitor.ProcessReading(
                new Sensor(
                    "SN1",
                    DateTime.Now,
                    "temperature",
                    51),
                "2026-09-01T08:01",
                "51");

            monitor.ProcessReading(
                new Sensor(
                    "SN1",
                    DateTime.Now,
                    "temperature",
                    52),
                "2026-09-01T08:02",
                "52");

            Assert.That(
                monitor.HasThreeConsecutiveBreaches("SN1"),
                Is.True);
        }


        [Test]
        public void TwoConsecutiveBreaches_ShouldNotTriggerAnomaly()
        {
            monitor.ProcessReading(
                new Sensor(
                    "SN1",
                    DateTime.Now,
                    "temperature",
                    50),
                "2026-09-01T08:00",
                "50");

            monitor.ProcessReading(
                new Sensor(
                    "SN1",
                    DateTime.Now,
                    "temperature",
                    51),
                "2026-09-01T08:01",
                "51");

            Assert.That(
                monitor.HasThreeConsecutiveBreaches("SN1"),
                Is.False);
        }

    }
}