//Write a program to check whether a number is positive, negative, or zero.
//Hint => 
//Get integer input from the user and store it in the number variable.
//If the number is positive, print positive.
//If the number is negative, print negative.
//If the number is zero, print zero. 
using System;
namespace Control_Flow
{
    internal class NumberIsPositiveNegativeOrZero
    {
        public static void CheckIfNumberIsPositiveNegativeOrZero()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}