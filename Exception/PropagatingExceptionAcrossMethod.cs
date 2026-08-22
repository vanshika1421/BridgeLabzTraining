//8.Propagating Exceptions Across Methods
//💡 Problem Statement:
//Create a C# program with three methods:
//Method1(): Throws an ArithmeticException(10 / 0).
//Method2(): Calls Method1().
//Main(): Calls Method2() and handles the exception.
//Expected Behavior:
//The exception propagates from Method1() → Method2() → Main().
//Catch and handle it in Main(), printing "Handled exception in Main".


using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class PropagatingExceptionAcrossMethod
    {
        public void Method1(int a , int b)
        {
            
                if (b == 0)
                {
                    throw new DivideByZeroException("Cant divide by zero");
                }
                int c = a / b;
                Console.WriteLine(c);
            }
            
        

        public void Method2(int a , int b)
        {
            Method1(a, b);
        }
    }
}
