//8.Create a program to find the youngest friends among 3 Amar, Akbar and Anthony based on their ages and tallest among the friends based on their heights and display it
//Hint => 
//a.               Take user input for age and height for the 3 friends and store it in two arrays each to store the values for age and height of the 3 friends
//b.               Write a Method to find the youngest of the 3 friends
//c.                Write a Method to find the tallest of the 3 friends

using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class YoungestAmong3
    {
        public static int FindYoungest(int[] ages)
        {
            if (ages.Length != 3)
            {
                throw new ArgumentException("Ages array must contain exactly 3 elements.");
            }
            int youngest = ages[0];
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < youngest)
                {
                    youngest = ages[i];
                }
            }
            return youngest;
        }
        public static double FindTallest(double[] heights)
        {
            if (heights.Length != 3)
            {
                throw new ArgumentException("Heights array must contain exactly 3 elements.");
            }
            double tallest = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > tallest)
                {
                    tallest = heights[i];
                }
            }
            return tallest;
        }
        public static void DisplayResults(int[] ages, double[] heights)
        {
            int youngest = FindYoungest(ages);
            double tallest = FindTallest(heights);
            Console.WriteLine($"The youngest friend is {youngest} years old.");
            Console.WriteLine($"The tallest friend is {tallest} meters tall.");
        }
    }
}
