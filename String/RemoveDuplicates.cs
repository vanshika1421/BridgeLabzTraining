//4.Remove Duplicates from a String
//Problem:
//Write a C# program to remove all duplicate characters from a given string and return the
//modified string.
    
using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class RemoveDuplicates
    {
        public static void removeDuplicate()
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            HashSet<char> seen = new HashSet<char>();
            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result.Append(c);
                }
            }
            Console.WriteLine("String after removing duplicates: " + result.ToString());
        }
    }
}
