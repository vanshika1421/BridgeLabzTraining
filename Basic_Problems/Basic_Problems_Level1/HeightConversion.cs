//using static System.Net.Mime.MediaTypeNames;

//10.Write a program that takes your height in centimeters and converts it into feet and inches
//Hint: 1 foot = 12 inches and 1 inch = 2.54 cm
//I/P => height
//O/P => Your Height in cm is ___ while in feet is ___ and inches is ___




using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problems
{
    internal class HeightConversion
    {
        public static void HeightConvert()
        {
            Console.WriteLine("Enter your height in centimeters: ");
            double heightInCm = Convert.ToDouble(Console.ReadLine());
            double heightInInches = heightInCm / 2.54;
            int feet = (int)(heightInInches / 12);
            double inches = heightInInches % 12;
            Console.WriteLine($"Your Height in cm is {heightInCm} while in feet is {feet} and inches is {inches}");
        }
    }
}
