using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;


//1.Write a program to take 2 numbers and print their quotient and remainder
//Hint: Use division operator (/) for quotient and modulus operator (%) for remainder
//I / P => number1, number2
//O / P => The Quotient is ___ and Remainder is ___ of two numbers ___ and
namespace Basic_Programs_Level2
{
    internal class QuotientRemainder
    {
        public static void QuotientAndRemainder()
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int quotient = number1 / number2;
            int remainder = number1 % number2;
            Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
        }
    }
}
