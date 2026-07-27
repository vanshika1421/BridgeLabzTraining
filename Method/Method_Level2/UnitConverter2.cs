//5.Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods. E.g.
//public static double ConvertYardsToFeet(double yards) =>
//a.Method to convert yards to feet and return the value. Use following code to convert  double yards2feet = 3;
//b.Method to convert feet to yards and return the value. Use following code to convert  double feet2yards = 0.333333;
//c.Method to convert meters to inches and return the value. Use following code to convert  double meters2inches = 39.3701;
//d.Method to convert inches to meters and return the value. Use following code to convert  double inches2meters = 0.0254;
//e.Method to convert inches to centimeters and return the value. Use the following code  double inches2cm = 2.54;


using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class UnitConverter2
    {
        public static double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards * yards2feet;
        }
        public static double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }
        public static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }
        public static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }
        public static double ConvertInchesToCentimeters(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }
        public static void DisplayResults(double yards, double feet, double meters, double inches)
        {
            Console.WriteLine($"{yards} yards is equal to {ConvertYardsToFeet(yards)} feet.");
            Console.WriteLine($"{feet} feet is equal to {ConvertFeetToYards(feet)} yards.");
            Console.WriteLine($"{meters} meters is equal to {ConvertMetersToInches(meters)} inches.");
            Console.WriteLine($"{inches} inches is equal to {ConvertInchesToMeters(inches)} meters.");
            Console.WriteLine($"{inches} inches is equal to {ConvertInchesToCentimeters(inches)} centimeters.");
        }
    }
}
