//2.Find Frequency of Elements
//Given a list of strings, count the frequency of each element and return the results in a Dictionary<string, int>.
//Example:
//Input: { "apple", "banana", "apple", "orange"}
//Output: { "apple": 2, "banana": 1, "orange": 1 }

using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Frequency
    {
        public Dictionary<String, int> frequencyCal(List<String> list)
        {
            Dictionary<String, int> dictionary = new Dictionary<string, int>();
            foreach (string s in list)
            {
                if (dictionary.ContainsKey(s))
                {
                    dictionary[s]++;
                }
                else
                {
                    dictionary[s] = 1;
                }
            }
            return dictionary;
        }
    }
}