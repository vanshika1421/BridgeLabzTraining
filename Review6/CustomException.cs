using System;
using System.Collections.Generic;
using System.Text;

namespace Review_6
{
    internal class UnknownSensorException : Exception

    {
        
        public UnknownSensorException() : base(){
            Console.WriteLine("UnknownSensor Exception");
        }
     
        //ExceptionsSensorException
        // ├── UnknownSensorTypeException
        // ├── InvalidSensorValueException
        // └── InvalidTimestampExceptionNUnit Testing — Minimum 8 Tests
    }
    public class InvalidSensorValueException : Exception
    {
        public InvalidSensorValueException() : base()
        {
            Console.WriteLine("Invalid sensor exception");
        }
    }
    public class InvalidTimestampException : Exception
    {
        public InvalidTimestampException(String message) : base(message)
        {
            Console.WriteLine("InvalidTimestampException ");
        }
    }
}
