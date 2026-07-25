//6.Create a program to print the greatest factor of a number beside itself using a loop.
//Hint =>
//Get an integer input and assign it to the number variable. As well as define a greatestFactor variable and assign it to 1
//Create a for loop that runs from last but one till 1 as in i = number - 1 to i = 1.
//Inside the loop, check if the number is perfectly divisible by i then assign i to greatestFactor variable and break the loop.
//Display the greatestFactor variable outside the loop
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level2
{
    internal class GreatestFactorOfNumber
    {
        public static void FindGreatestFactor()
        {
            Console.WriteLine("Enter a number to find its greatest factor beside itself:");
            int number = Convert.ToInt32(Console.ReadLine());
            int greatestFactor = 1;
            for (int i = number - 1; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    greatestFactor = i;
                    break;
                }
            }
            Console.WriteLine($"The greatest factor of {number} beside itself is: {greatestFactor}");
        }
    }
}
