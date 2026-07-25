using System;
using System.Collections.Generic;
using System.Text;

//Write a program to check for the natural number and write the sum of n natural numbers 
//Hint => 
//A Natural Number is a positive integer (1,2,3, etc) sometimes with the inclusion of 0
//A sum of n natural numbers is n * (n+1) / 2 
//I/P => number
//O/P => If the number is a positive integer then the output is
//The sum of ___ natural numbers is ___
//Otherwise 
//The number ___ is not a natural number

namespace Control_Flow
{
    internal class SumOfNaturalNumbers
    {
        public static void CalculateSumOfNaturalNumbers()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                int sumOfNaturalNumbers = num * (num + 1) / 2 ;
                Console.WriteLine("The sum of first {0} natural numbers is {1}", num, sumOfNaturalNumbers); 
            }
            else
            {
                Console.WriteLine("The number {0} is not a natural number", num);
            }
        }
    }
}
