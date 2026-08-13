//2.Validate a License Plate Number
//License plate format: Starts with two uppercase letters, followed by four digits.
//Example: "AB1234" is valid, but "A12345" is invalid.
using System.Text.RegularExpressions;

using System;
using System.Collections.Generic;
using System.Text;

namespace regex_code
{
    public class License_validator
    {
        public bool License_validate(string str)
        {
            string pattern = @"^[A-Z][A-Z][0-9][0-9][0-9][0-9]";
            return Regex.IsMatch(str, pattern);
        }

    }
}
