//14.Find Repeating Words in a Sentence
//Example Input: "This is is a repeated repeated word test."
//Expected Output:
//is, repeated


using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexx
{
    internal class FindRepeatedWords
    {
        public void RepeatedWords()
        {
            String text = "This is is a repeated repeated word test.";
           // String[] words = text.Split(' ');
            MatchCollection match = Regex.Matches(text, @"\b(\w+)\s+\1\b" );
            foreach(Match m in match)
            {
                Console.WriteLine( m.Groups[1].Value );
            }

        }
    }
}
