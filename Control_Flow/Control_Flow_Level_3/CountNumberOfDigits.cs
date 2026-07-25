using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3
{
    internal class CountNumberOfDigits
    {
        public static void CountDigits()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine($"The number of digits is: {count}");
        }
    }
}
