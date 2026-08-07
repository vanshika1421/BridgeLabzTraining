//Reverse(string str): Returns the reverse of a given string.

using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_testing_examples
{
    public class ReverseString
    {
        public string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
