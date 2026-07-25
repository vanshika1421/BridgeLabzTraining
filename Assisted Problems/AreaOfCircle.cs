using System;
using System.Collections.Generic;
using System.Text;
//4.Area of a Circle
//Write a program to calculate the area of a circle. Take the radius as input
//and use the formula:
//Area = π * radius ^ 2.

namespace Assisted_Problems
{
    internal class AreaOfCircle
    {
        public static void AreaOfCircleCalculation()
        {
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the circle with radius {0} is: {1}", radius, area);
        }
    }
}
