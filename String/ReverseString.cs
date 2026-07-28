//2.Reverse a String
//Problem:
//Write a C# program to reverse a given string without using any built-in reverse functions.
    
using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class ReverseString
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine() ?? " ";
            int i = 0;
            int j =s.Length-1;
            char[] arr = s.ToCharArray();
            while (i < j)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            string reversed = new string(arr);
            Console.WriteLine($"Reversed string: {reversed}");
        }
    }
}
