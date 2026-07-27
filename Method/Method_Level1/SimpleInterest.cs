//Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
//Hint => 
//Simple Interest = Principal * Rate * Time / 100
//Take user input for principal, rate, time
//Write a method to calculate the simple interest given principle, rate and time as parameters
//Output “The Simple Interest is ___ for Principal ___, Rate of Interest ___ and Time ___”

using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class SimpleInterest
    {
        public static void SimpleInterestCalculation()
        {
            Console.WriteLine("Enter the Principal amount:");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest (in percentage):");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time (in years):");
            double time = Convert.ToDouble(Console.ReadLine());
            double simpleInterest = CalculateSimpleInterest(principal, rate, time);
            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
        }
        private static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }

}
