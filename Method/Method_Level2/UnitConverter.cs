//4.Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods. E.g.
//public static double ConvertKmToMiles(double km) =>
//a.Method To convert kilometers to miles and return the value. Use the following code  double km2miles = 0.621371;
//b.Method to convert miles to kilometers and return the value. Use the following code  double miles2km = 1.60934;
//c.Method to convert meters to feet and return the value. Use the following code to convert  double meters2feet = 3.28084;
//d.Method to convert feet to meters and return the value. Use the following code to convert  double feet2meters = 0.3048;

using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class UnitConverter
    {
        public static double ConvertKmToMiles(double km)
        {
            double km2miles = 0.621371;
            return km * km2miles;
        }
        public static double ConvertMilesToKm(double miles)
        {
            double miles2km = 1.60934;
            return miles * miles2km;
        }
        public static double ConvertMetersToFeet(double meters)
        {
            double meters2feet = 3.28084;
            return meters * meters2feet;
        }
        public static double ConvertFeetToMeters(double feet)
        {
            double feet2meters = 0.3048;
            return feet * feet2meters;
        }
        public static void DisplayResults(double km, double miles)
        {
            Console.WriteLine($"{km} kilometers is equal to {ConvertKmToMiles(km)} miles.");
            Console.WriteLine($"{miles} miles is equal to {ConvertMilesToKm(miles)} kilometers.");
            Console.WriteLine($"{km} meters is equal to {ConvertMetersToFeet(km)} feet.");
            Console.WriteLine($"{miles} feet is equal to {ConvertFeetToMeters(miles)} meters.");
        }
    }
}
