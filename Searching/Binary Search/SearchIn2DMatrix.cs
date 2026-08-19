//Binary Search Problem 3: Search for a Target Value in a 2D Sorted Matrix
//Problem: You are given a 2D matrix where each row is sorted in ascending order.
//Write a program that performs Binary Search to find a target value in the matrix.

using System;
using System.Collections.Generic;
using System.Text;

namespace Linear_Search
{
    public class SearchIn2DMatrix
    {
        public bool FindTargetElement(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int low = 0;
            int high = rows*cols-1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int row = mid / cols;
                int col = mid % cols;
                if (matrix[row, col] == target)
                {
                    return true;
                }
                else if (matrix[row, col] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return false;
        }
    }
}
