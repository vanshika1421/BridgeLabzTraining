//11.Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
//Hint:
//Simple Interest = (Principal * Rate * Time) / 100
//I/P => principal, rate, time
//O/P => The Simple Interest is ___ for Principal ___, Rate of Interest ___ and Time ___

using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs_Level2
{
    internal class SimpleInterest
    {
        public static void SimpleInterestCalculation() { 
        Console.WriteLine("Enter the Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time period in years: ");
            int years = Convert.ToInt32(Console.ReadLine());
            double simpleInterest = (principal * rate * years) / 100;
            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {years}");
        }
    }
}
