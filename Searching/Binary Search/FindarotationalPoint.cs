//Binary Search Problem 1: Find the Rotation Point in a Rotated Sorted Array
//Problem: You are given a rotated sorted array.
//Write a program that performs Binary Search to find the index of the smallest element in the array.



using System;
using System.Collections.Generic;
using System.Text;

namespace Linear_Search
{
   public class FindarotationalPoint
    {
        public int findSmallestElement(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j) {
                int mid = i + (j - i) / 2;
                if (arr[mid] > arr[j])
                {
                    i = mid + 1;
                }
                else
                {
                    j = mid;
                }
                    }
            return i;
        }
    }
}
