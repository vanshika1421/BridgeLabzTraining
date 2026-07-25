//Write a program SpringSeason that takes two int values month and day from the command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
//Hint => 
//Spring Season is from March 20 to June 20
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SpringSeasonOrNot
    {
        public static void CheckIfSpringSeasonOrNot()
        {
            Console.WriteLine("Enter the month (1-12):");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the day (1-31):");
            int day = int.Parse(Console.ReadLine());
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }
    }
}
