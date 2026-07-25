//Create a program to print a multiplication table of a number.
//Hint =>
//a. Get an integer input and store it in the number variable. Also, define a integer array to
//store the results of multiplication from 1 to 10
//b. Run a loop from 1 to 10 and store the results in the multiplication table array
//c. Finally, display the result from the array in the format number * i = ___
using System;

namespace Arrays
{
    internal class MultiplicationTableOfNumber
    {
        public static void number(int num)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = num * (i + 1);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("table");
        }
    }
}

