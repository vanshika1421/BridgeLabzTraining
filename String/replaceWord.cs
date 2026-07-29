using System;

namespace String
{
    internal class ReplaceWord
    {
        public static void Replace()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine() ?? "";

            Console.Write("Enter the word to replace: ");
            string oldWord = Console.ReadLine() ?? "";

            Console.Write("Enter the new word: ");
            string newWord = Console.ReadLine() ?? "";

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == oldWord)
                {
                    words[i] = newWord;
                }
            }

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                result += words[i];

                if (i != words.Length - 1)
                {
                    result += " ";
                }
            }

            Console.WriteLine("Updated Sentence:");
            Console.WriteLine(result);
        }
    }
}