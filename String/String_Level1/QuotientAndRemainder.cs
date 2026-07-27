//9.Write a program to take 2 numbers and print their quotient and reminder
//Hint => 
//Take user input as integer
//Use division operator (/) for quotient and moduli operator (%) for reminder
//Write Method to find the reminder and the quotient of a number 
//public static int[] FindRemainderAndQuotient(int number, int divisor)
using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class QuotientAndRemainder
    {
        public static void CalculateQuotientAndRemainder()
        {
            Console.WriteLine("Enter the dividend (number):");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int[] result = FindRemainderAndQuotient(number, divisor);
            Console.WriteLine($"The quotient is {result[0]} and the remainder is {result[1]}");
        }

        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;
            return new int[] { quotient, remainder };
        }


    }
}
