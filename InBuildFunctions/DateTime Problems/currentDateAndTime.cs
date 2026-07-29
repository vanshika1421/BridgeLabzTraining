//1.Problem 1: Time Zones and DateTimeOffset
//Write a program that displays the current time in different time zones:
//● GMT(Greenwich Mean Time)
//● IST(Indian Standard Time)
//● PST(Pacific Standard Time)
//Hint: Use DateTimeOffset and TimeZoneInfo to work with different time zones.
    
using System;
using System.Collections.Generic;
using System.Text;

namespace InBuildFunctions
{
    internal class currentDateAndTime
    {
        public static void displayDateAndTime(DateTime date)
        {
            DateTimeOffset currentTime = DateTimeOffset.Now;
            TimeZoneInfo gmt = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            Console.WriteLine($"GMT : {TimeZoneInfo.ConvertTime(currentTime, gmt)}");
            Console.WriteLine($"IST : {TimeZoneInfo.ConvertTime(currentTime, ist)}");
            Console.WriteLine($"PST : {TimeZoneInfo.ConvertTime(currentTime, pst)}");

            Console.WriteLine("Current time in Different Time Zones");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"GMT : {gmt}");
            Console.WriteLine($"IST : {ist}");
            Console.WriteLine($"PST : {pst}");
        }
    }
}
