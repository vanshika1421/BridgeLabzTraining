using System;
using System.Collections.Generic;
using System.Text;

//12.Write a program that takes the base and height to find the area of a triangle in square inches and square centimeters
//Hint: Area of a Triangle is ½ * base * height
//I/P => base, height
//O/P => Your Height in cm is ___ while in feet is ___ and inches is ___


namespace Basic_Problems
{
    internal class AreaOfTriangle
    {
        public static void AreaCalculation()
        {
            Console.WriteLine("Enter the base of the triangle in inches: ");
            double baseInInches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle in inches: ");
            double heightInInches = Convert.ToDouble(Console.ReadLine());
            double areaInSquareInches = 0.5 * baseInInches * heightInInches;
            double areaInSquareCentimeters = areaInSquareInches * 6.4516; // 1 square inch = 6.4516 square centimeters
            Console.WriteLine($"The area of the triangle is {areaInSquareInches} square inches and {areaInSquareCentimeters} square centimeters.");
        }
    }
}
