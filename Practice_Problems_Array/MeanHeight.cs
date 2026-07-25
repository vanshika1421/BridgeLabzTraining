using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
//Create a program to find the mean height of players present in a football team.
//Hint =>
//a. The formula to calculate the mean is: mean = sum of all elements / number of elements
//b. Create a double array named heights of size 11 and get input values from the user.
//c. Find the sum of all the elements present in the array.
//d. Divide the sum by 11 to find the mean height and print the mean height of the football
//team

namespace Practice_Problems_Array
{
    internal class MeanHeight
    {
        public static void meanHeight()
        {
            double[] heights = new double[11];
            double sum = 0.0;
            Console.WriteLine("Enter the heights of 11 players in meters:");
            for (int i = 0; i < heights.Length; i++)
            {
                Console.Write($"Player {i + 1}: ");
                heights[i] = double.Parse(Console.ReadLine());
                sum += heights[i];
            }
            double mean = sum / heights.Length;
            Console.WriteLine($"The mean height of the football team is: {mean:F2} meters");
        }
    }
}
