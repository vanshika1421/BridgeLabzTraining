//8.Write a program to find the smallest and the largest of the 3 numbers.
//Hint => 
//Take user input for 3 numbers
//Write a single method to find the smallest and largest of the three numbers
//public static int[] FindSmallestAndLargest(int number1, int number2, int number3)

using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class SmallestAndLargest
    {
        public static void FindSmallestAndLargestNumbers()
        {
            Console.WriteLine("Enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int[] result = FindSmallestAndLargest(number1, number2, number3);
            Console.WriteLine($"The smallest number is {result[0]} and the largest number is {result[1]}");
        }
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = Math.Min(number1, Math.Min(number2, number3));
            int largest = Math.Max(number1, Math.Max(number2, number3));
            return new int[] { smallest, largest };
        }

    }
}
