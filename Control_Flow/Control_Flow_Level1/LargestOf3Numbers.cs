//Write a program to check if the first, second, or third number is the largest of the three.
//I/P => number1, number2, number3
//O/P => 
//Is the first number the largest? ____
//Is the second number the largest? ___

using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class LargestOf3Numbers
    {
        public static void FindLargestOf3Numbers()
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int thirdNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("Yes, the first number {0} is the largest of the three numbers", firstNumber);
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("Yes, the second number {0} is the largest of the three numbers", secondNumber);
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine("Yes, the third number {0} is the largest of the three numbers", thirdNumber);
            }
            else
            {
                Console.WriteLine("There is a tie for the largest number among the three.");
            }
        }
    }
}
