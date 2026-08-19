

//Binary Search Problem 2: Find the Peak Element in an Array
//Problem: A peak element is an element that is greater than its neighbors.
//Write a program that performs Binary Search to find a peak element in an array.


using System;
using System.Collections.Generic;
using System.Text;

namespace Linear_Search
{
    public class PeakElement
    {
        public int FindPeakElement(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                int mid = i + (j - i) / 2;
              
                 if (arr[mid] < arr[mid + 1])
                {
                    i = mid+1;
                }
                else
                {
                    j = mid ;
                }

            }
            return i;

        }
    }
}
