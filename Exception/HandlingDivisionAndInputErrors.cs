//2.Handling Division and Input Errors
//💡 Problem Statement:
//Write a C# program that asks the user to enter two numbers and divides them. Handle possible exceptions such as:
//DivideByZeroException if division by zero occurs.
//FormatException if the user enters a non-numeric value.
//Expected Behavior:
//If the user enters valid numbers, print the result of the division.
//If the user enters 0 as the denominator, catch and handle DivideByZeroException.
//If the user enters a non-numeric value, catch and handle FormatException.


using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class HandlingDivisionAndInputErrors
    {
        public void check(int a , int b)
        {
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cant divide by 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Non numeric value");
            }
        }
    }
}
