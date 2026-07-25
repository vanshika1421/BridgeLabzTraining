using System;
using System.Collections.Generic;
using System.Text;
//3.Create a program to convert the distance of 10.8 kilometers to miles.
//Hint: 1 km = 1.6 miles
//I/P => NONE
//O/P => The distance ___ km in miles is ___

namespace Basic_Problems
{
    internal class DistanceCal
    {
        public static void DistanceConversion()
        {
            double kilometers = 10.8;
            double miles = kilometers * 1.6;
            Console.WriteLine("The distance "+ kilometers + "km in miles is"+ miles);
        }
    }
}
