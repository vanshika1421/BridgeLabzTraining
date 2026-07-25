//Rewrite the program number 12 with the for loop instead of a while loop to find the sum of n Natural Numbers. 
//Hint => 
//Take the user input number and check whether it's a Natural number
//If it's a natural number Compute using formulae as well as compute using for loop
//Compare the two results and print the result
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SumOfNaturalNumbers3
    {
        public static void CalculateSumOfNaturalNumbersUsingForLoop()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                int sumOfNaturalNumbersUsingFormula = num * (num + 1) / 2;
                int sumOfNaturalNumbersUsingForLoop = 0;
                for (int i = 1; i <= num; i++)
                {
                    sumOfNaturalNumbersUsingForLoop += i;
                }
                Console.WriteLine("The sum of first {0} natural numbers using formula is {1}", num, sumOfNaturalNumbersUsingFormula);
                Console.WriteLine("The sum of first {0} natural numbers using for loop is {1}", num, sumOfNaturalNumbersUsingForLoop);
            }
            else
            {
                Console.WriteLine("The number {0} is not a natural number", num);
            }
        }
    }
}
