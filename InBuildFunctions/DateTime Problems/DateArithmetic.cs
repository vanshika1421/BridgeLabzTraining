//using System.Runtime.Intrinsics.X86;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//2.Problem 2: Date Arithmetic
//Create a program that:
//● Takes a date input and adds 7 days, 1 month, and 2 years to it.
//● Then subtracts 3 weeks from the result.
//Hint: Use DateTime.AddDays(), DateTime.AddMonths(), DateTime.AddYears(),
//and DateTime.AddWeeks() methods.

using System;

namespace InBuildFunctions
{
    internal class DateArithmetic
    {
        public static void DateCalculation(DateTime date)
        {
            DateTime result = date.AddDays(7)
                                  .AddMonths(1)
                                  .AddYears(2)
                                  .AddDays(-21);

            Console.WriteLine("Original Date : " + date.ToShortDateString());
            Console.WriteLine("Final Date    : " + result.ToShortDateString());
        }
    }
}