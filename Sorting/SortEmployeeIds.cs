//2.Insertion Sort - Sort Employee IDs
//Problem Statement:
//A company stores employee IDs in an unsorted array. Implement Insertion Sort in C# to sort the employee IDs in ascending order.
//Hint:
//Divide the array into sorted and unsorted parts.
//Pick an element from the unsorted part and insert it into its correct position in the sorted part.
//Repeat for all elements.


using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class SortEmployeeIds
    {
        public void InsertionSort(int[] Ids)
        {
            for (int i = 1; i < Ids.Length; i++)
            {
                int key = Ids[i];
                int j = i - 1;
                while (j >= 0 && Ids[j] > key)
                {
                    Ids[j + 1] = Ids[j];
                    j = j - 1;
                }
                Ids[j + 1] = key;

            }
            for (int i = 0; i < Ids.Length; i++)
            {
                Console.WriteLine(Ids[i]);
            }
        }
    }
}
