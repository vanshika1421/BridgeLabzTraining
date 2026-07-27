//Write a program to check whether a number is positive, negative, or zero.
//Hint => Get integer input from the user. Write a Method to return -1 for negative number, 1 for positive number and 0 if number is zero

using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class NumberIsPositiveNegativeOrZero
    {
        public static void CheckNumber()
        {
            Console.WriteLine("Enter an integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = DetermineNumberType(number);
            if (result == 1)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (result == -1)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        private static int DetermineNumberType(int num)
        {
            if (num > 0)
            {
                return 1; // Positive
            }
            else if (num < 0)
            {
                return -1; // Negative
            }
            else
            {
                return 0; // Zero
            }
        }
    }
}
