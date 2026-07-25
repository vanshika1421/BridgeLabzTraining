using System;
using System.Collections.Generic;
using System.Text;

//3.Similarly, write the DoubleOpt program by taking double values and doing the same operations.
//I/P => a, b, c
//O/P => The results of Double Operations are ___, ___, and ___

namespace Basic_Programs_Level2
{
    internal class OperatorPrecedence2
    {
        public static void DoubleOperations()
        {
            Console.WriteLine("Enter the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double result1 = a + b * c;
            double result2 = a * b + c;
            double result3 = c + a / b;
            double result4 = a % b + c;
            Console.WriteLine($"The results of Double Operations are {result1}, {result2}, and {result4}");
        }
    }
}
