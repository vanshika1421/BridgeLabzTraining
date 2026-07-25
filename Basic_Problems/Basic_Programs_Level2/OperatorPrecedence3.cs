//8.Rewrite the Sample Program 2 with user inputs
//Hint:
//Create variables and take user inputs for name, fromCity, viaCity, toCity.
//Create variables and take user inputs for distances: fromToVia and
//viaToFinalCity in miles.
//Create variables and take the time taken for the journey.
//Finally, print the results and try to understand operator precedence.
//I/P => name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity, timeTaken
//O/P => The results of the trip are: ___, ___, and ___
    using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs_Level2
{
    internal class OperatorPrecedence3
    {
        public static void UserInputTripDetails()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the starting city: ");
            string fromCity = Console.ReadLine();
            Console.WriteLine("Enter the via city: ");
            string viaCity = Console.ReadLine();
            Console.WriteLine("Enter the destination city: ");
            string toCity = Console.ReadLine();
            Console.WriteLine("Enter the distance from starting city to via city (in miles): ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the distance from via city to destination city (in miles): ");
            double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time taken for the journey (in hours): ");
            double timeTaken = Convert.ToDouble(Console.ReadLine());
            double totalDistance = fromToVia + viaToFinalCity;
            double averageSpeed = totalDistance / timeTaken;
            Console.WriteLine($"The results of the trip are: Name: {name}, From: {fromCity}, Via: {viaCity}, To: {toCity}, Total Distance: {totalDistance} miles, Average Speed: {averageSpeed} mph");
        }
    }
}
