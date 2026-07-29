//10.Remove a Specific Character from a String
//Problem:
//Write a C# program to remove all occurrences of a specific character from a string.
//Example Input:
//String: "Hello World"
//Character to Remove: 'l'
//Expected Output:
//Modified String: "Heo Word"
    
using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class RemoveSpecificCharater
    {
        public static void removeSpecificChar()
        {
            Console.WriteLine("Enter string");

            string s = Console.ReadLine() ?? "";
            Console.WriteLine("Enter the char to remove");
            string s2 = Console.ReadLine() ?? "";
            string s3 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s2[0])
                {
                    s3 += s[i];
                }
            }

            Console.WriteLine($"{ s3}");
        }
    }
}
    
