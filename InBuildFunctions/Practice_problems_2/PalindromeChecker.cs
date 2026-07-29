using System;

namespace Functions
{
    internal class PalindromeChecker
    {
        public static void Run()
        {
            string text = GetInput();

            if (IsPalindrome(text))
            {
                Console.WriteLine("The given string is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The given string is not a Palindrome.");
            }
        }

        // Method to take input
        public static string GetInput()
        {
            Console.Write("Enter a string: ");
            return Console.ReadLine();
        }

        // Method to check palindrome
        public static bool IsPalindrome(string text)
        {
            int start = 0;
            int end = text.Length - 1;

            while (start < end)
            {
                if (text[start] != text[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}