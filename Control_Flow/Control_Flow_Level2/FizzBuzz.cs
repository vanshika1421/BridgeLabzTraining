//Rewrite the program 5 FizzBuzz using while loop 
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level2
{
    internal class FizzBuzz
    {
        public static void PrintFizzBuzz()
        {
            Console.WriteLine("Enter a number to print FizzBuzz up to that number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= number)
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
                i++;
            }
        }
    }

}
