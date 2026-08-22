//9.Using Nested try-catch Blocks
//💡 Problem Statement:
//Write a C# program that:
//Takes an array and a divisor as input.
//Tries to access an element at an index.
//Tries to divide that element by the divisor.
//Uses nested try-catch to handle:
//IndexOutOfRangeException if the index is invalid.
//DivideByZeroException if the divisor is zero.
//Expected Behavior:
//If valid, print the division result.
//If the index is invalid, catch and display "Invalid array index!".
//If division by zero, catch and display "Cannot divide by zero!"


using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class NestedTryCatch
    {
        public void DivideArray(int[] arr , int d)
        {
            try
            {
                Console.WriteLine("Enter index");
                int a = int.Parse(Console.ReadLine());
                if(a <0 || a >= arr.Length)
                {
                    throw new IndexOutOfRangeException("iNVALID INDEX");
                }
                Console.WriteLine("Element is " + arr[a]);
                try
                {
                    int ans = arr[a] / d;
                   

                    Console.WriteLine(arr[a] / d);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch(IndexOutOfRangeException e) {
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}
