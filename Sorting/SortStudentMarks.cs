//1.Bubble Sort - Sort Student Marks
//Problem Statement:
//A school maintains student marks in an array. Implement Bubble Sort in C# to sort the student marks in ascending order.
//Hint:
//Traverse through the array multiple times.
//Compare adjacent elements and swap them if needed.
//Repeat the process until no swaps are required.


using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class SortStudentMarks
    {
        public void BubbleSort(int[] marks)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < marks.Length-1; i++)
            {
                swapped = false;
                for (j = 0; j < marks.Length - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j+1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }

            for (i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }

}