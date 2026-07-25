//2.Add Two Numbers
//Write a program that takes two numbers as input from the user and prints
//their sum.
 using System;
using System.Collections.Generic;
using System.Text;

namespace Assisted_Problems
{
    internal class AddTwoNumbers
    {
        public static void AddTwoNumber()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum);
        }
    }
}
