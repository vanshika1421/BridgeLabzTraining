using Review_6;
using static System.Net.WebRequestMethods;

namespace Review6_testing
{
    public class Tests
    {
        private Sensor sen;
        private Thresholds thresholds;
        [SetUp]
        public void Setup()
        {
            sen = new Sensor();
            thresholds = new Thresholds();
        }

       [Test]
        public void Testing_ValueBelowMinimum()
        {
            Sensor s1 = new Sensor
            {
                SensorId = 2,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
                Type = "Temperature",
                Value = -11f
            };
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

            Assert.That(thresholds.Validate_sensor_Value(list, s1), Is.False);
        }
        [Test]
        public void Testing_ValueAboveMaximum()
        {
            Sensor s1 = new Sensor
            {
                SensorId = 2,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
                Type = "Temperature",
                Value = 50f
            };
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

            Assert.That(thresholds.Validate_sensor_Value(list, s1), Is.False);
        }
        [Test]
        public void ValueExactly_At_Maximum()
        {
            Sensor s1 = new Sensor
            {
                SensorId = 2,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
                Type = "Temperature",
                Value = 45f
            };
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

            Assert.That(thresholds.Validate_sensor_Value(list, s1), Is.True);
        }
        [Test]
        public void Value_Exactly_At_Minimum()
        {
          
            Sensor s1 = new Sensor
            {
                SensorId = 2,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
                Type = "Temperature",
                Value = -10f
            };
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

            Assert.That(thresholds.Validate_sensor_Value(list, s1), Is.True);



        }
        [Test]
        public void Testing_Unknown_SensorType()
        {
            List<Sensor> s = new List<Sensor>();
            Sensor s0 = new Sensor
            {
                SensorId = 1,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
                Type = "temperature",
                Value = 23.5f
            };
            s.Add(s0);
            Sensor s1 = new Sensor
            {
                SensorId = 2,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
                Type = "temperature",
                Value = 23.5f
            };
            s.Add(s1);
            Sensor s2 = new Sensor
            {
                SensorId = 3,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 5),
                Type = "Humidity",
                Value = 23.5f
            };
            s.Add(s2);
            Sensor s3 = new Sensor
            {
                SensorId = 4,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 5),
                Type = "Pressure",
                Value = 23.5f
            };
            s.Add(s3);
            Sensor s4 = new Sensor
            {
                SensorId = 1,
                Timestamp = new DateTime(2026, 9, 1, 8, 1, 0),
                Type = "Voltage",
                Value = 23.5f
            };
            s.Add(s4);
            Sensor s5 = new Sensor
            {
                SensorId = 1,
                Timestamp = new DateTime(2026, 9, 1, 8, 1, 0),
                Type = "temperature",
                Value = 23.5f
            };
            s.Add(s5);
            String type = "Humidity";

            Assert.That(sen.ValidSensors_Type(s, type), Is.True);
        }
        [Test]
        public void detect_3_Consecutive_threshold()
        {
            List<Sensor> s = new List<Sensor>();
            Sensor s0 = new Sensor
            {
                SensorId = 1,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
                Type = "temperature",
                Value = 23.5f
            };
            s.Add(s0);
            Sensor s1 = new Sensor
            {
                SensorId = 2,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 0),
                Type = "temperature",
                Value = 23.5f
            };
            s.Add(s1);
            Sensor s2 = new Sensor
            {
                SensorId = 3,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 5),
                Type = "Humidity",
                Value = 95f
            };
            s.Add(s2);
            Sensor s3 = new Sensor
            {
                SensorId = 4,
                Timestamp = new DateTime(2026, 9, 1, 8, 0, 5),
                Type = "Pressure",
                Value = 23.5f
            };
            s.Add(s3);
            Sensor s4 = new Sensor
            {
                SensorId = 1,
                Timestamp = new DateTime(2026, 9, 1, 8, 1, 0),
                Type = "Pressure",
                Value = 23.5f
            };
            s.Add(s4);
            Sensor s5 = new Sensor
            {
                SensorId = 1,
                Timestamp = new DateTime(2026, 9, 1, 8, 1, 0),
                Type = "temperature",
                Value = 23.5f
            };
            s.Add(s5);
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
            Assert.That(thresholds.detect_3_Consecutive_threshold(list, s), Is.True);
        }
        public void testing_Blank_Sensor_Value()
        {

        }
        public void Rolling_window_retains_only_latest_five_records()
        {

        }
    }
}
