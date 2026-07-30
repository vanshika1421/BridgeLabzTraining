//2.Program to Compute Area of a Circle
//Problem Statement: Write a program to create a Circle class with an attribute radius.Add methods to calculate and display the area and circumference of the circle.



using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class areaOfCircle
    {
      public double radius = 0;
        public double area;
        public double circumference;
        public areaOfCircle(double radius)
        {
            this.radius = radius;
        }
        public double areaCalculation()
        {
            area = Math.PI* radius*radius;
            return area;
        }
        public double circumferenceOfCircle()
        {
            circumference = 2*Math.PI*radius;
            return circumference;
        }
        public void DisplayDetails()
        {
            areaCalculation();
            Console.WriteLine("Area Of Circle is: "+ area.ToString("F3"));
            circumferenceOfCircle();
            Console.WriteLine("Circumference Of Circle is : " + circumference.ToString("F3"));
        }
    }
}
