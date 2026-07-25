//Create a program to print odd and even numbers between 1 to the number entered by the user.
//Hint => 
//Get an integer input from the user, assign to a variable number and check for Natural Number
//Using a for loop, iterate from 1 to the number
//In each iteration of the loop, print the number is odd or even number
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class OddEvenNumber
    {
        public static void PrintOddEvenNumbers()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0} is an even number", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} is an odd number", i);
                    }
                }
            }
            else
            {
                Console.WriteLine("The number {0} is not a natural number", number);
            }
        }
    }
}
