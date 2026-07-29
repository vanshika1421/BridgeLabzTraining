using System;

namespace String
{
    internal class MostFrequentCharacter
    {
        public static void Frequency()
        {
            int[] freq = new int[26];

            Console.Write("Enter the string: ");
            string s = Console.ReadLine().ToLower();

            // Count frequency of each character
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    freq[s[i] - 'a']++;
                }
            }

            int max = 0;
            char mostFrequent = ' ';

            // Find maximum frequency
            for (int i = 0; i < 26; i++)
            {
                if (freq[i] > max)
                {
                    max = freq[i];
                    mostFrequent = (char)(i + 'a');
                }
            }

            Console.WriteLine("Most Frequent Character: " + mostFrequent);
        }
    }
}