using System;
using System.Collections.Generic;
using System.Text;
//2.Write an IntOperation program by taking a, b, and c as input values and print the following integer operations: a + b * c, a* b +c, c +a / b, and a % b + c. Please also understand the precedence of the operators.
//Hint:
//Create variables a, b, and c of int data type.
//Take user input for a, b, and c.
//Compute the 3 integer operations and assign results to variables.
//Finally, print the results and understand operator precedence.
//I/P => a, b, c
//O/P => The results of Int Operations are ___, ___, and ___

namespace Basic_Programs_Level2
{
    internal class OperatorPrecedence
    {
        public static void IntOperations()
        {
            Console.WriteLine("Enter the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int result1 = a + b * c;
            int result2 = a * b + c;
            int result3 = c + a / b;
            int result4 = a % b + c;

            Console.WriteLine($"The results of Int Operations are {result1}, {result2}, and {result4}");
        }
    }
}
