//3.Power Calculation
//Write a program that takes two numbers as input: a base and an exponent,
//and prints the result of base raised to the exponent (without using loops or
//conditionals).
using System;
using System.Collections.Generic;
using System.Text;

namespace Self_Problems
{
    internal class PowerCalculation
    {
        public static void CalculatePower()
        {
            Console.WriteLine("Enter the base number:");
            double baseNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent:");
            double exponent = double.Parse(Console.ReadLine());
            double result = Math.Pow(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {result}");
        }
    }
}
