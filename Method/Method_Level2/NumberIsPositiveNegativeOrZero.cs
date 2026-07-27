//9.Write a program to take user input for 5 numbers and check whether a number is positive or negative. Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they are equal, greater, or less
//Hint => 
//a.               Write a Method to Check whether the number is positive or negative
//b.               Write a Method to check whether the number is even or odd
//c.                Write a Method to compare two numbers and return 1 if number1 > number2 or 0 if both are equal or -1 if number1 < number2 
//d.               In the main program, Loop through the array using the length call the method isPositive() and if positive call method isEven() and print accordingly 
//e.               If the number is negative, print negative. 
//f.                 Finally compare the first and last element of the array by calling the method compare() and display if they are equal, greater, or less

using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class NumberIsPositiveNegativeOrZero
    {
        public static string IsPositive(int number)
        {
            if (number > 0)
            {
                return "Positive";
            }
            else if (number < 0)
            {
                return "Negative";
            }
            else
            {
                return "Zero";
            }
        }
        public static string IsEven(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
        public static int Compare(int number1, int number2)
        {
            if (number1 > number2)
            {
                return 1;
            }
            else if (number1 < number2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static void CheckNumbers()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                string positivity = IsPositive(numbers[i]);
                Console.WriteLine($"Number {numbers[i]} is {positivity}.");
                if (positivity == "Positive")
                {
                    string evenOdd = IsEven(numbers[i]);
                    Console.WriteLine($"Number {numbers[i]} is {evenOdd}.");
                }
            }
            int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);
            if (comparisonResult == 1)
            {
                Console.WriteLine($"First number {numbers[0]} is greater than last number {numbers[numbers.Length - 1]}.");
            }
            else if (comparisonResult == -1)
            {
                Console.WriteLine($"First number {numbers[0]} is less than last number {numbers[numbers.Length - 1]}.");
            }
            else
            {
                Console.WriteLine($"First number {numbers[0]} is equal to last number {numbers[numbers.Length - 1]}.");
            }
        }
        
    }
}
