//9.An athlete runs in a triangular park with sides provided as input by the
//user in meters. If the athlete wants to complete a 5 km run, then how many
//rounds must the athlete complete?
//Hint:
//The perimeter of a triangle is the addition of all sides.

//Rounds = distance / perimeter
//I/P => side1, side2, side3
//O/P => The total number of rounds the athlete will run is ___ to complete 5
//km
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs_Level2
{
    internal class RoundCalculator
    {
        public static void CalculateRounds()
        {
            Console.WriteLine("Enter the length of side 1 in meters: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side 2 in meters: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side 3 in meters: ");
            double side3 = Convert.ToDouble(Console.ReadLine());
            double perimeter = side1 + side2 + side3;
            double distance = 5000; // 5 km in meters
            double rounds = distance / perimeter;
            Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km");
        }
    }
}
