using System;
using System.Collections.Generic;
using System.Text;

namespace Assisted_Problems
{
    internal class VolumeOfCylinder
    {
        public static void VolumeOfCylinderCalculation()
        {
            Console.WriteLine("Enter the radius of the cylinder: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the cylinder: ");
            double height = double.Parse(Console.ReadLine());
            double volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine("The volume of the cylinder with radius {0} and height {1} is: {2}", radius, height, volume);
        }
    }
}
