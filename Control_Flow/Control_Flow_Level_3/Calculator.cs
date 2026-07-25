//Write a program to create a calculator using switch...case.
//Hint => 
//Create two double variables named first and second and a String variable named op.
//Get input values for all variables.
//The input for the operator can only be one of the four values: "+", "-", "*" or "/".
//Run a for loop from i = 1 to i < number.
//Based on the input value of the op, perform specific operations using the switch...case statement and print the result.
//If op is +, perform addition between first and second; if it is -, perform subtraction and so on.
//If op is neither of those 4 values, print Invalid Operator.

using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3
{
    internal class Calculator
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter first number:");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator (+, -, *, /):");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result: {first + second}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {first - second}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {first * second}");
                    break;
                case "/":
                    if (second != 0)
                    {
                        Console.WriteLine($"Result: {first / second}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operator.");
                    break;
            }
        }
    }
}
