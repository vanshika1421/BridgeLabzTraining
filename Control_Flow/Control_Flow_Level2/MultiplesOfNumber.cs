//9.Create a program to find all the multiple of a number taken as user input below 100.
//Hint => 
//Get input value for a variable named number.
//Run a for loop backward: from i = 100 to i = 1.
//Inside the loop, check if i perfectly divide the number.
//If true, print the number and continue the loop.
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level2
{
    internal class MultiplesOfNumber
    {
        public static void FindMultiples()
        {
            Console.WriteLine("Enter a number to find its multiples below 100:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiples of {number} below 100 are:");
            for (int i = 100; i >= 1; i--)
            {
                if (i % number == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
