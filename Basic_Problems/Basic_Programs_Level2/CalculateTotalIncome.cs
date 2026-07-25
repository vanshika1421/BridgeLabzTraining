//6.Create a program to find the total income of a person by taking salary and
//bonus from the user
//Hint:
//Create a variable named salary and take user input.
//Create another variable bonus and take user input.
//Compute income by adding salary and bonus and print the result.
//I/P => salary, bonus
//O/P => The salary is INR ___ and bonus is INR ___. Hence Total Income is INR

using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs_Level2
{
    internal class CalculateTotalIncome
    {
        public static void TotalIncome()
        {
            Console.WriteLine("Enter the salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine());
            double totalIncome = salary + bonus;
            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}");
        }
    }
}
