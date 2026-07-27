//An athlete runs in a triangular park with sides provided as input by the user in meters. If the athlete wants to complete a 5 km run, then how many rounds must the athlete complete
//Hint => 
//Take user input for 3 sides of a triangle 
//The perimeter of a triangle is the addition of all sides and rounds is distance/perimeter
//Write a Method to compute the number of rounds user needs to do to complete 5km run

using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class NumberOfRounds
    {
        public static void CalculateNumberOfRounds()
        {
            Console.WriteLine("Enter the length of side A of the triangular park (in meters):");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side B of the triangular park (in meters):");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side C of the triangular park (in meters):");
            double sideC = Convert.ToDouble(Console.ReadLine());
            double perimeter = CalculatePerimeter(sideA, sideB, sideC);
            double rounds = CalculateRounds(perimeter);
            Console.WriteLine($"The athlete needs to complete {rounds} rounds to complete a 5 km run.");
        }
        private static double CalculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
        private static double CalculateRounds(double perimeter)
        {
            const double distanceToRun = 5000; // 5 km in meters
            return distanceToRun / perimeter;
        }
    }
}
