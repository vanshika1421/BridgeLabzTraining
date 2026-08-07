using System;
using System.Collections.Generic;
using System.Text;

/*2. Testing Password Strength Validator
Problem:
Create a PasswordValidator class with:
Passwords must have at least 8 characters, one uppercase letter, and one digit.
✅ Write unit tests for valid and invalid passwords.
*/
namespace Advance_Unit_Testing
{
    public class PasswordStrength
    {
        public  bool PasswordCheck(string str)
        {
            if (str.Length<8 || !str.Any(char.IsUpper) || !str.Any(char.IsDigit))
            {
                return false;
            }
            return true;

                 }
    }
}
