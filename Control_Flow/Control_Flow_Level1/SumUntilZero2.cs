using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SumUntilZero2
    {
        public static void SumUntilZero()
        {
            double total = 0;
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            while (number > 0)
            {
                total += number;

                Console.Write("Enter a number: ");
                number = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Total = " + total);
        }
    }
}
