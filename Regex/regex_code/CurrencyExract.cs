//13.Extract Currency Values from a Text
//Example Text: "The price is $45.99, and the discount is $ 10.50."
//Expected Output:
//$45.99, 10.50


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regexx
{
    internal class CurrencyExract
    {
        public void ExtractCurrency()
        {
            String text = "The price is $45.99, and the discount is $ 10.50.";
            MatchCollection match = Regex.Matches(text, @"\d+\.\d+");
            foreach (Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
