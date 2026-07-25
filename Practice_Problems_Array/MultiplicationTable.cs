using System;
using System.Collections.Generic;
using System.Text;
//Create a program to find the multiplication table of a number entered by the user from 6 to 9
//and display the result
//Hint =>
//a. Take integer input and store it in the variable number as well as define an integer array
//to store the multiplication result in the variable multiplicationResult
//b. Using a for loop, find the multiplication table of numbers from 6 to 9 and save the result
//in the array
//c. Finally, display the result from the array in the format number * i = ___

namespace Practice_Problems_Array
{
    internal class MultiplicationTable
    {
        public static void multiplicationTable()
        {
            Console.WriteLine("Enter a number to find its multiplication table from 6 to 9:");
            int number = int.Parse(Console.ReadLine());
            int[] multiplicationResult = new int[4];
            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[i - 6] = number * i;
            }
            Console.WriteLine($"Multiplication table of {number} from 6 to 9:");
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
            }
        }
    }
}
