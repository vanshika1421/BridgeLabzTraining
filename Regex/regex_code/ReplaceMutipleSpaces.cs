//Replace and Modify Strings
//8. Replace Multiple Spaces with a Single Space
//Example Input: "This is an example with multiple spaces."
//Expected Output: "This is an example with multiple spaces."


using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexx
{
    internal class ReplaceMutipleSpaces
    {
        public  void ReplaceSpace()
        {
            String ans = "My     name is Vanshika.";
            String result = Regex.Replace(ans , @"\s+", " ");
            Console.WriteLine(result);
        }
    }
}
