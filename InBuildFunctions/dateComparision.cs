//using System.Runtime.Intrinsics.X86;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//4.Problem 4: Date Comparison
//Write a program that:
//● Takes two date inputs and compares them to check if the first date is
//before, after, or the same as the second date.

//Hint: Use DateTime.Compare(), DateTime.CompareTo(), or direct comparison
//using DateTime methods.
    

using System;
using System.Collections.Generic;
using System.Text;

namespace InBuildFunctions
{
    internal class dateComparision
    {
        public static void DateComparision(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);
            if (result < 0)
            {
                Console.WriteLine("first date is before seocnd date");
            }
            else if (result > 0)
            {
                Console.WriteLine("first date is after second date");
            }
            else
            {
                Console.WriteLine("Both are same date");
            }
        }
    }
}
