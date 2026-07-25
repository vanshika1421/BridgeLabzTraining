using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3
{
    internal class ArmstrongNumber
    {
        public static void CheckArmstrongNumber()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            int sum = 0;
            int digits = number.ToString().Length;
            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
                number /= 10;
            }
            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number.");
            }
        }
    }
}
