//1.Create a program to find the factors of a number taken as user input, store the factors in an array and display the factors. Also find the sum, sum of square of factors and product of the factors and display the results
//Hint => 
//Take the input for a number
//Write a static Method to find the factors of the number and save them in an array and return the array. 
//To find factors and save to array will have two loops. The first loop to find the count and initialize the array with the count. And the second loop save the factors into the array
//Write a method to find the sum of the factors using factors array
//Write a method to find the product of the factors using factors array
//Write a method to find the sum of square of the factors using Math.Pow() method
using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class FindFactors
    {
        public static int[] GetFactors(int number)
        {
            //Console.WriteLine("Enter number");
            //int number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index++] = i;
                }
            }
            return factors;
        }
        public static int SumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }
        public static int ProductOfFactors(int[] factors)
        {
            int product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }
        public static double SumOfSquareOfFactors(int[] factors)
        {
            double sumOfSquares = 0;
            foreach (int factor in factors)
            {
                sumOfSquares += Math.Pow(factor, 2);
            }
            return sumOfSquares;
        }
        public static void DisplayResults(int[] factors)
        {
            Console.WriteLine("Factors: " + string.Join(", ", factors));
            Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));
            Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));
            Console.WriteLine("Sum of Square of Factors: " + SumOfSquareOfFactors(factors));

        }
    }
}
