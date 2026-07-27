//Write a program SpringSeason that takes two int values month and day from the command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
//Hint => Spring Season is from March 20 to June 20. Write a Method to check for Spring season and return a boolean true or false 

using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class SpringSeason
    {
        public static void CheckSpringSeason()
        {
            Console.WriteLine("Enter the month (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day (1-31):");
            int day = Convert.ToInt32(Console.ReadLine());
            bool isSpring = IsSpringSeason(month, day);
            if (isSpring)
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }
        private static bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            {
                return true;
            }
            return false;
        }
    }
}
