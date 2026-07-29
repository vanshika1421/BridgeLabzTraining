using System;

namespace Functions
{
    internal class FactorialRecursion
    {
        public static void Run()
        {
            int number = GetNumber();

            long factorial = FindFactorial(number);

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }

        // Method to take input
        public static int GetNumber()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        // Recursive method to find factorial
        public static long FindFactorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            return number * FindFactorial(number - 1);
        }
    }
}