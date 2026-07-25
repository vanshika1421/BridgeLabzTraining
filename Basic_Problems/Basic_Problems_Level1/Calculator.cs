using System;
using System.Collections.Generic;
using System.Text;

//11.Write a program to create a basic calculator that can perform addition, subtraction, multiplication, and division. The program should ask for two numbers (floating point) and perform all the operations
//Hint:
//Create a variable number1 and number 2 and take user inputs.
//Perform Arithmetic Operations of addition, subtraction, multiplication, and division and assign the result to a variable and finally print the result
//I/P => number1, number2
//O/P => The addition, subtraction, multiplication and division value of 2 numbers ___ and ___ is ___, ____, ____, and ___

namespace Basic_Problems
{
    internal class Calculator
    {
        public static void CalculatorMethod()
        {
            Console.WriteLine("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double addition = number1 + number2;
            double subtraction = number1 - number2;
            double multiplication = number1 * number2;
            double division = number1 / number2;
            Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {number1} and {number2} is {addition}, {subtraction}, {multiplication}, and {division}");
        }
    }
}
