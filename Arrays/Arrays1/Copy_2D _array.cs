using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Problems_Array
{
    internal class Copy_2D__array
    {
         public static void CopyArray()
        {
          Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("\nEnter the elements of the matrix:");

            // Input for 2D array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Create 1D array
            int[] array = new int[rows * cols];
            int index = 0;

            // Copy elements from 2D array to 1D array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[index] = matrix[i, j];
                    index++;
                }
            }

            // Display 2D array
            Console.WriteLine("\n2D Array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Display 1D array
            Console.WriteLine("\n1D Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
    }
}
}
