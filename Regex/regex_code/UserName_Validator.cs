using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace regex_code
{

    //    1. Validate a Username
    //A valid username:
    //Can only contain letters(a-z, A-Z), numbers(0-9), and underscores(_)
    //Must start with a letter
    //Must be between 5 to 15 characters long
    //Example Inputs & Outputs:
    //✅ "user_123" → Valid
    //❌ "123user" → Invalid(starts with a number)
    //❌ "us" → Invalid(too short)
    using System.Text.RegularExpressions;

    public class UserName_Validator
    {
        public bool username_valid(string username)
        {
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
            return Regex.IsMatch( username, pattern);
           
        }
    }
}
