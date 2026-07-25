//Write a Program to find the factorial of an integer entered by the user.
//Hint => 
//For example, the factorial of 4 is 1 * 2 * 3 * 4 which is 24.
//Take an integer input from the user and assign it to the variable. Check the user has entered a positive integer.
//Using a while loop, compute the factorial.
//Print the factorial at the end.
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class Factorial
    {
        public static void FactorialOfNumber()
        {
            Console.WriteLine("Enter a positive integer to find its factorial");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                int factorial = 1;
            
             for(int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("The factorial of {0} is {1}", num, factorial);
            }
            else
            {
                Console.WriteLine("The number {0} is not a positive integer", num);
            }
        }
    }
}
