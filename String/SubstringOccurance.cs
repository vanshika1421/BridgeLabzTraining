//6.Find Substring Occurrences
//Problem:
//Write a C# program to count how many times a given substring occurs in a string.
    
using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class SubstringOccurance
    {
        public static void substringOccurance()
        {
            int count = 0;
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine() ?? "";
            Console.WriteLine("Enter a substring to search for");
            string sub = Console.ReadLine() ?? "";
            for (int i = 0; i < s.Length-sub.Length; i++)
            {
                    if (s.Substring(i, sub.Length) == sub)
                {
                    count++;        
                }
            }
            Console.WriteLine(count);
        }
    }
}
