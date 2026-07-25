//7.Write a Program to compute the volume of Earth in km^3 and miles^3
//Hint: Volume of a Sphere is (4/3) * pi * r^3 and radius of earth is 6378 km
//O/P => The volume of earth in cubic kilometers is ____ and cubic miles is ____



using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problems
{
    internal class VolumeOfEarth
    {
        public static void VolumeCalculation()
        {
            double radius = 6378; // in kilometers
            double volumeInKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            double volumeInMiles3 = volumeInKm3 * 0.621371; // Convert km^3 to miles^3
            Console.WriteLine($"The volume of earth in cubic kilometers is {volumeInKm3:F2} and cubic miles is {volumeInMiles3:F2}");
        }
    }
}
