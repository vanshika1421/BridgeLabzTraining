//5.Convert Kilometers to Miles
//Write a program that takes the distance in kilometers as input from the user
//and converts it into miles using the formula:
//Miles = Kilometers * 0.621371.
using System;
using System.Collections.Generic;
using System.Text;

namespace Self_Problems
{
    internal class ConvertKmToM
    {
        public static void ConvertToMiles()
        {
            Console.WriteLine("Enter the distance in kilometers:");
            double kilometers = double.Parse(Console.ReadLine());
            double miles = kilometers * 0.621371;
            Console.WriteLine($"The distance in miles is: {miles}");
        }
    }
}
