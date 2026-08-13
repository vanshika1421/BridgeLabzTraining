//15.Validate a Social Security Number (SSN)
//Example Input: "My SSN is 123-45-6789."
//Expected Output:
//✅ "123-45-6789" is valid
//❌ "123456789" is invalid

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regexx
{
    internal class ValidSSN
    {
        public bool ValidSSNumber()
        {
            String text = "My SSN is 123-45-6789.";
            return Regex.IsMatch(text , @"\d\d\d-\d\d-\d\d\d\d");
        }
    }
}
