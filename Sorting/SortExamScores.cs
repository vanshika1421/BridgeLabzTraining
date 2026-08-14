//5.Selection Sort - Sort Exam Scores
//Problem Statement:
//A university needs to sort students’ exam scores in ascending order. Implement Selection Sort in C# to achieve this.
//Hint:
//Find the minimum element in the array.
//Swap it with the first unsorted element.
//Repeat the process for the remaining elements.


using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class SortExamScores
    {
        public void SelectionSort(int[] score)
        {
            for (int i = 0; i < score.Length-1; i++)
            {
                int min_score = i;
                for (int j = i + 1; j < score.Length; j++)
                {
                    if (score[j] < score[min_score])
                    {
                        min_score = j;

                    }
                }
                int temp = score[i];
                score[i] = score[min_score];
                score[min_score] = temp;
            }
            foreach (int i in score)
            {
                Console.WriteLine(i);
            }
        }
    }
}
