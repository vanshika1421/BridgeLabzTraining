//Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights
//Hint => 
//Take user input for age and height for the 3 friends and store it in two arrays each to store the values for age and height of the 3 friends
//Loop through the array and find the youngest of the 3 friends and the tallest of the 3 friends
//Finally display the youngest and tallest of the 3 friends

using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays2
{
    internal class YoungestAmongThree
    {
        public static void YoungestAmongThreeMethod()
        {
            double[] age = new double[3];
            double[] height = new double[3];
            string[] names = { "Amar", "Akbar", "Anthony" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the age of " + names[i] + ": ");
                age[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of " + names[i] + ": ");
                height[i] = double.Parse(Console.ReadLine());
            }
            int youngestIndex = 0;
            int tallestIndex = 0;
            for (int i = 1; i < 3; i++)
            {
                if (age[i] < age[youngestIndex])
                {
                    youngestIndex = i;
                }
                if (height[i] > height[tallestIndex])
                {
                    tallestIndex = i;
                }
            }
            Console.WriteLine("The youngest friend is " + names[youngestIndex] + " with age " + age[youngestIndex]);
            Console.WriteLine("The tallest friend is " + names[tallestIndex] + " with height " + height[tallestIndex]);
        }
    }
}
