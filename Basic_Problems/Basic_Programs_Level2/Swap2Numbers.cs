//7.Create a program to swap two numbers
//Hint:
//Create a variable number1 and take user input.
//Create a variable number2 and take user input.
//Swap number1 and number2 and print the swapped output.
//I/P => number1, number2
//O/P => The swapped numbers are ___ and ___
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs_Level2
{
    internal class Swap2Numbers
    {
        public static void SwapNumbers()
        {
            Console.WriteLine("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Swapping the numbers
            double temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"The swapped numbers are {number1} and {number2}");
        }
    }
}
