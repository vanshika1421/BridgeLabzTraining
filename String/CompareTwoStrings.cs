//8.Compare Two Strings
//Problem:
//Write a C# program to compare two strings lexicographically (dictionary order) without
//using built-in compare methods.
//Example Input:
//String 1: "apple"
//String 2: "banana"
//Expected Output:
//"apple" comes before "banana" in lexicographical order
using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class CompareTwoStrings
    {
        public static void CompareTwoString()
        {
            Console.WriteLine("Enter string1");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter strng2");
            string str2 = Console.ReadLine();
            int i = 0;
            while(i < str1.Length & i < str2.Length)
            {
                if (str1[i] < str2[i])
                {
                    Console.WriteLine($" {str1} comes before {str2}");
                    return;
                }
                else
                {
                    Console.WriteLine($"{str2} comes before {str1}");
                    return;
                }
                i++;
            }
            if (str2.Length > str1.Length)
            {
                Console.WriteLine($"{str1} comes before {str2}");
            }
            else
            {
                Console.WriteLine($"{str2} comes before {str1}");
            }

        }
    }
}
