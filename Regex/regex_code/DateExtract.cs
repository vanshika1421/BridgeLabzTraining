//6.Extract Dates in dd/mm/yyyy Format
//Example Text: "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020."
//Expected Output:
//12 / 05 / 2023, 15 / 08 / 2024, 29 / 02 / 2020

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regexx
{
    internal class DateExtract
    {
        public void ExtractDates()
        {
            String text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
            MatchCollection res = Regex.Matches(text, @"\d+/\d+/\d+");
            foreach (Match m in res)
            {
                Console.WriteLine(m.Value);
            }


        }
    }
}
