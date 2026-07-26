//Write a program to take user input for 5 numbers and check whether a number is positive,
//negative, or zero. Further for positive numbers check if the number is even or odd. Finally
//compare the first and last elements of the array and display if they equal, greater or less
//Hint =>
//a. Define an integer array of 5 elements and get user input to store in the array.
//b. Loop through the array using the length If the number is positive, check for even or odd
//numbers and print accordingly
//c. If the number is negative, print negative. Else if the number is zero, print zero.
//d. Finally compare the first and last element of the array and display if they equal, greater
//or less
using System;

namespace Arrays
{
    internal class PositiveNegativeZero
    {
 public static void CheckNumbers()
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 numbers:");

            // Input
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Check each number
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine(arr[i] + " is positive");
                }
                else if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i] + " is negative");
                }
                else
                {
                    Console.WriteLine(arr[i] + " is zero");
                }
            }
        }
    }
}
