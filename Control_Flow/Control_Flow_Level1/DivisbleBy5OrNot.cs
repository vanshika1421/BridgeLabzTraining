//Write a program to check if a number is divisible by 5
//I/P => number
//O/P => Is the number ___ divisible by 5? ___

using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class DivisbleBy5OrNot
    {
        public static void checkNumberDivisbleByFive()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num% 5 == 0)
            {
                Console.Write("Yes , the num {0} is divisible by 5", num);
            }
            else
            {
                Console.WriteLine("No ,  the num {0} is not divisible by 5", num);
            }
        }
    }
}
