using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SumOfNaturalNumbers2
    {
        public static void CalculateSumOfNaturalNumbers()
        {
            Console.WriteLine("Enter a positive integer:");
            int n = int.Parse(Console.ReadLine());
            int temp = n; // Store the original value of n for output
            int sum = 0;
            while (temp > 0)
            {
                sum+=temp;
                temp--;
            }
            Console.WriteLine("The sum of the first {0} natural numbers is: {1}" ,n , sum);

            int sumFormula = n * (n + 1) / 2;
            Console.WriteLine("The sum calculated using the formula n*(n+1)/2 is: {0}", sumFormula);

            if(sum == sumFormula)
            {
                Console.WriteLine("Both methods give the same result.");
            }
            else
            {
                Console.WriteLine("There is a discrepancy between the two methods.");
            }
        }
    }
}
