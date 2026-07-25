//Write a program FizzBuzz, take a number as user input, and if it is a positive integer loop from 0 to the number and print the number, but for multiples of 3 print "Fizz" instead of the number, for multiples of 5 print "Buzz", and for multiples of both print "FizzBuzz".
//Hint => 
//Write the program and use for loop

using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level2
{
    internal class FizzBuzz2
    {
        public static void PrintFizzBuzz()
        {
            Console.WriteLine("Enter a positive integer to print FizzBuzz up to that number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }
            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
