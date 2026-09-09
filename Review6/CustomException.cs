using System;

namespace Review_6
{
    public class SensorException : Exception
    {
        public SensorException(string message) : base(message) { }
    }

    public class UnknownSensorTypeException : SensorException
    {
        public UnknownSensorTypeException(string message) : base(message) { }
    }

    public class InvalidSensorValueException : SensorException
    {
        public InvalidSensorValueException(string message) : base(message) { }
    }

    public class InvalidTimestampException : SensorException
    {
        public InvalidTimestampException(string message) : base(message) { }
    }
}
