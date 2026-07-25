//Write a program to check if the first is the smallest of the 3 numbers.
//I/P => number1, number2, number3
//O/P => Is the first number the smallest? ____
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class FirstIsSmallestOrNot

    {
        public static void checkIfFirstNumberIsSmallestOrNot()
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int thirdNumber = int.Parse(Console.ReadLine());
            if(firstNumber<secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine("Yes the first number {0} is the smallest of the three numbers", firstNumber);
            }
            else
            {
                Console.WriteLine("No, the first number {0} is not the smallest of the three numbers", firstNumber);
            }
        }
    }
}
