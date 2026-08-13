//5.Extract All Capitalized Words from a Sentence
//Example Text: "The Eiffel Tower is in Paris and the Statue of Liberty is in New York."
//Expected Output:
//Eiffel, Tower, Paris, Statue, Liberty, New, York

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regexx

{
    internal class ExtractAllCapitalisedWords
    {
        public void ExtractCapital()
        {
            String input = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            MatchCollection ans = Regex.Matches(input, @"\b[A-Z][a-z]*\b");
            //foreach (Match m in ans)
            //{
            //    Console.WriteLine(m);
            //}
            for (int i = 1; i < ans.Count; i++)
            { 
               Console.WriteLine(ans[i].Value);
            }
        }
    }
}
