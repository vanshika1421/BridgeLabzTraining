using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
//2.Perimeter of a Rectangle
//Write a program to calculate the perimeter of a rectangle. Take the length
//and width as inputs and use the formula:
//Perimeter = 2 * (length + width).
namespace Self_Problems
{
    internal class PerimeterOfRectangle
    {
        public static void FindPerimeterOfRectangle()
        {
            Console.WriteLine("Enter the length of the rectangle:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle:");
            int width = int.Parse(Console.ReadLine());
            int perimeter = 2 * (length + width);
            Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
        }
    }
}
