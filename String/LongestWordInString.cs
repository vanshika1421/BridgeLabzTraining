//5.Find the Longest Word in a Sentence
//Problem:
//Write a C# program that takes a sentence as input and returns the longest word in the
//sentence.
    
using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class LongestWordInString
    {
        public static void longestWord()
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine("The longest word in the sentence is: " + longestWord);
        }
    }
}
