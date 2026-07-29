using System;

namespace Functions
{
    internal class MaximumOfThree
    {
        public static void Run()
        {
            int num1 = GetNumber("Enter first number: ");
            int num2 = GetNumber("Enter second number: ");
            int num3 = GetNumber("Enter third number: ");

            int maximum = FindMaximum(num1, num2, num3);

            Console.WriteLine("Maximum number is: " + maximum);
        }

        // Method to take input
        public static int GetNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        // Method to find maximum
        public static int FindMaximum(int num1, int num2, int num3)
        {
            int max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            return max;
        }
    }
}