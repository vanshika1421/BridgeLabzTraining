//Create a program to find the maximum number of handshakes among N number of students.
//Hint => 
//Get integer input for numberOfStudents variable.
//Use the combination = (n * (n - 1)) / 2 formula to calculate the maximum number of possible handshakes.
//Display the number of possible handshakes.

using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class HandshakeProblem2
    {
        public static void CalculateMaximumHandshakes()
        {
            Console.WriteLine("Enter the number of students:");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            int maxHandshakes = CalculateHandshakes(numberOfStudents);
            Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}");
        }
        private static int CalculateHandshakes(int n)
        {
            return (n * (n - 1)) / 2;
        }
    }
}
