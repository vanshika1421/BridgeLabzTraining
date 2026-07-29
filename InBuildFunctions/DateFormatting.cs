using System.Runtime.Intrinsics.X86;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//3.Problem 3: Date Formatting
//Write a program that:
//● Displays the current date in three different formats:
//o dd/MM/yyyy
//o yyyy-MM-dd
//o EEE, MMM dd, yyyy

//Hint: Use DateTime.ToString() with custom date format strings.
    
using System;
using System.Collections.Generic;
using System.Text;

namespace InBuildFunctions
{
    internal class DateFormatting
    {
        public static void dateFormatting(DateTime date)
        {
            Console.Write(date.ToString("dd/MM/yyyy"));
            Console.Write(date.ToString("yyyy-MM-dd"));
            Console.Write(date.ToString("ddd, MMM dd , yyyy"));
        }
    }
}
