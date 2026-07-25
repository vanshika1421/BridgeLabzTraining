//4.Calculate Average of Three Numbers
//Write a program that takes three numbers as input from the user and prints
//their average.
using System;
using System.Collections.Generic;
using System.Text;

namespace Self_Problems
{
    internal class AvgOfNumbers
    {
        public static void CalculateAverage()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            double num3 = double.Parse(Console.ReadLine());
            double average = (num1 + num2 + num3) / 3;
            Console.WriteLine($"The average of {num1}, {num2}, and {num3} is: {average}");
        }
    }
}
