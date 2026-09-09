using System;
using System.Collections.Generic;
using System.Text;

namespace Review_6
{
    public class BreachRecord
    {
        public string SensorId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
        public bool Anomaly { get; set; }
    }
}
