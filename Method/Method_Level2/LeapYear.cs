//3.Write a program that takes a year as input and outputs the Year is a Leap Year or not 
//Hint => 
//a.               The LeapYear program only works for year >= 1582, corresponding to a year in the 
//                  Gregorian calendar. 
//b.               Also Leap year is divisible by 4 and not divisible by 100 or divisible by 400
//c.                Write a method to check for Leap Year using the conditions a and b


using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            if (year < 1582)
            {
                throw new ArgumentException("Year must be greater than or equal to 1582.");
            }
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        public static void CheckLeapYear(int year)
        {
            try
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine($"{year} is a Leap Year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a Leap Year.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
