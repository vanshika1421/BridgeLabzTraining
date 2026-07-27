//Write a program to find the sum of n natural numbers using loop
//Hint => Get integer input from the user. Write a Method to find the sum of n natural numbers using loop 



using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class SumOfNaturalNumbers
    {
        public static void CalculateSumOfNaturalNumbers()
        {
            Console.WriteLine("Enter a positive integer n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = CalculateSum(n);
            Console.WriteLine($"The sum of the first {n} natural numbers is {sum}");
        }
        private static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
