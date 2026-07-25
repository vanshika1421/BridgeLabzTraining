using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class MultiplicationTable
    {
        public static void multiplicationTable()
        {
            Console.WriteLine("Enter a number to generate its multiplication table:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
