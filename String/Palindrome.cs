//3.Palindrome String Check
//Problem:
//Write a C# program to check if a given string is a palindrome (a string that reads the
//same forward and backward).
using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class Palindrome
    {
        public static void CheckPalindrome()
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine()?? "";
            int i = 0;
            int j = s.Length - 1;
            while(i < j)
            {
                if (s[i] != s[j])
                {
                    Console.WriteLine("Not a palindrome");
                    return;
                }
                i++;
                j--;
            }
            Console.WriteLine("It is a palindrome");
        }
    }
}
