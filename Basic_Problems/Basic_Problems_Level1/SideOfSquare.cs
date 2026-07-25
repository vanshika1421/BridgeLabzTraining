using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;




//13.Write a program to find the side of the square whose perimeter you read from user
//Hint: Perimeter of Square is 4 times side
//I/P => perimeter
//O/P => The length of the side is ___ whose perimeter is ____

namespace Basic_Problems
{
    internal class SideOfSquare_
    {
        public static void SideOfSquare()
        {
            Console.WriteLine("Enter the perimeter of the square: ");
            double perimeter = Convert.ToDouble(Console.ReadLine());
            double side = perimeter / 4;
            Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
        }
    }
}
