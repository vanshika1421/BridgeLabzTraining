//7.Create a program to find the power of a number.
//Hint => 
//Get integer input for two variables named number and power.
//Create a result variable with an initial value of 1.
//Run a for loop from i = 1 to i <= power.
//In each iteration of the loop, multiply the result with the number and assign the value to the result.
//Finally, print the result
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level2
{
    internal class PowerOfNumber
    {
        public static void FindPower()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power:");
            int power = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            Console.WriteLine($"The power of {number} raised to {power} is: {result}");
        }
    }
}
