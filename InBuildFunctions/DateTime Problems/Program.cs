using InBuildFunctions;
using System;
namespace DisplayDateAndTime { 
    internal class Program
    {
        public static void Main(string[] args)
        {
            //currentDateAndTime.displayDateAndTime(DateTime.Now);
            // DateArithmetic.DateCalculation(DateTime.Now);
            //DateFormatting.dateFormatting(DateTime.Now);
           
            dateComparision.DateComparision(DateTime.Now, Convert.ToDateTime("14/07/2004"));
        }
    }
}