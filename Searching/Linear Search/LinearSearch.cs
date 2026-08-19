//Linear Search Problem 1: Search for the First Negative Number
//Problem: You are given an integer array. Write a program that performs Linear Search to find the first negative number in the array.


using System;
using System.Collections.Generic;
using System.Text;

namespace Linear_Search
{
    internal class LinearSearch
    {
        public void SearchFirstNegativeNumber(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                    return; 
                }
            }

        }
    }
}
