//1.Count Vowels and Consonants
//Problem:
//Write a C# program to count the number of vowels and consonants in a given string.
    
using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class CountConsonantsAndVowels
    {
        public static void CountVowelsAndConsonants()
        {
            int countVowels = 0;
            int countConsonants = 0;
            Console.WriteLine("Enter a string ");
            string s = Console.ReadLine();
            s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                {
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    {
                        countVowels++;
                    }
                    else if (char.IsLetter(s[i]))
                    {
                        countConsonants++;
                    }
                }
            }
                Console.WriteLine($"Number of vowels:  {countVowels}");
                Console.WriteLine($"Number of consonants: {countConsonants}");
            }
        
    }
}
