using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

//14.Write a program to find the distance in yards and miles for the distance provided by the user in feet
//Hint: 1 mile = 1760 yards and 1 yard is 3 feet
//I/P => distanceInFeet
//O/P => Your Height in cm is ___ while in feet is ___ and inches is ___

namespace Basic_Problems
{
    internal class FindDistanceInYard
    {
        public static void DistanceInYard()
        {
            Console.WriteLine("Enter the distance in feet: ");
            double distanceInFeet = Convert.ToDouble(Console.ReadLine());
            double distanceInYards = distanceInFeet / 3;
            double distanceInMiles = distanceInYards / 1760;
            Console.WriteLine($"The distance of {distanceInFeet} feet is {distanceInYards} yards and {distanceInMiles} miles.");
        }
    }
}
