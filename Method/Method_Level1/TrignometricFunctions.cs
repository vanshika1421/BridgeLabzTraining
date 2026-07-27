//12.Write a program to calculate various trigonometric functions using Math class given an angle in degrees
//Hint => 
//Method to calculate various trigonometric functions, Firstly convert to radians and then use Math function to find sine, cosine and tangent.
//public double[] calculateTrigonometricFunctions(double angle)

using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class TrignometricFunctions
    {
        public static void CalculateTrigonometricFunctions()
        {
            Console.WriteLine("Enter the angle in degrees:");
            double angleInDegrees = Convert.ToDouble(Console.ReadLine());
            double[] trigFunctions = CalculateTrigFunctions(angleInDegrees);
            Console.WriteLine($"For angle {angleInDegrees} degrees:");
            Console.WriteLine($"Sine: {trigFunctions[0]}");
            Console.WriteLine($"Cosine: {trigFunctions[1]}");
            Console.WriteLine($"Tangent: {trigFunctions[2]}");
        }
        public static double[] CalculateTrigFunctions(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double sine = Math.Sin(angleInRadians);
            double cosine = Math.Cos(angleInRadians);
            double tangent = Math.Tan(angleInRadians);
            return new double[] { sine, cosine, tangent };
        }
    }
}
