//12.Create a program to convert weight in pounds to kilograms.
//Hint:
//1 pound = 2.2 kg
//I/P => weight (in pounds)
//O/P => The weight of the person in pounds is ___ and in kg is ___

using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs_Level2
{
    internal class WeightConversion
    {
        public static void ConvertWeight()
        {
            Console.WriteLine("Enter the weight in pounds: ");
            double weightInPounds = Convert.ToDouble(Console.ReadLine());
            double weightInKg = weightInPounds / 2.2;
            Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKg}");
        }
    }
}
