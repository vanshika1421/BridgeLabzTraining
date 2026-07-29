using System;

namespace Functions
{
    internal class NumberGuessingGame
    {
        static Random random = new Random();

        public static void Run()
        {
            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("Press Enter when you are ready...");
            Console.ReadLine();

            int low = 1;
            int high = 100;
            bool isGuessed = false;

            while (!isGuessed)
            {
                int guess = GenerateGuess(low, high);

                Console.WriteLine("\nIs your number " + guess + "?");

                char feedback = GetFeedback();

                isGuessed = ProcessFeedback(feedback, guess, ref low, ref high);
            }

            Console.WriteLine("Computer guessed your number successfully!");
        }

        // Method to generate a random guess
        public static int GenerateGuess(int low, int high)
        {
            return random.Next(low, high + 1);
        }

        // Method to get user's feedback
        public static char GetFeedback()
        {
            Console.Write("Enter H (High), L (Low), or C (Correct): ");
            return Convert.ToChar(Console.ReadLine().ToUpper());
        }

        // Method to process feedback and update the range
        public static bool ProcessFeedback(char feedback, int guess, ref int low, ref int high)
        {
            switch (feedback)
            {
                case 'H':
                    high = guess - 1;
                    return false;

                case 'L':
                    low = guess + 1;
                    return false;

                case 'C':
                    return true;

                default:
                    Console.WriteLine("Invalid input! Please enter H, L, or C.");
                    return false;
            }
        }
    }
}