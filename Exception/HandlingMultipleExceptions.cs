//4.Handling Multiple Exceptions
//💡 Problem Statement:
//Create a C# program that performs array operations.
//Accept an integer array and an index number.
//Retrieve and print the value at that index.
//Handle the following exceptions:
//IndexOutOfRangeException if the index is out of range.
//NullReferenceException if the array is null.
//Expected Behavior:
//If valid, print "Value at index X: Y".
//If the index is out of bounds, display "Invalid index!".
//If the array is null, display "Array is not initialized!".

using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class HandlingMultipleExceptions
    {
        public void printArray(int[] arr , int i)
        {
            try
            {
                if (arr == null)
                {
                    throw new NullReferenceException("Array is not instialized");
                }
                else if (i > arr.Length)
                {
                    throw new IndexOutOfRangeException("index is not valid");
                }
                else
                {
                    Console.Write(arr[i]);
                }

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
