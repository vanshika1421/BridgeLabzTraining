using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class InvalidAgeException : System.Exception
    {
        public InvalidAgeException(String msg) : base(msg) { }
    }

    internal class InvalidInputException : System.Exception
    {
        public InvalidInputException(String msg) : base(msg) { }
    }
}
