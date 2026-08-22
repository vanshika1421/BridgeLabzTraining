//7.Demonstrating finally Block Execution
//💡 Problem Statement:
//Write a program that performs integer division and demonstrates the finally block execution.
//The program should:
//Take two integers from the user.
//Perform division.
//Handle DivideByZeroException (if dividing by zero).
//Ensure "Operation completed" is always printed using finally.
//Expected Behavior:
//If valid, print the result.
//If an exception occurs, handle it and still print "Operation completed".


using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class FinallyBlockExecution
    {
        public void Divide(int a , int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("opeation completed");
            }
        }
    }
}
