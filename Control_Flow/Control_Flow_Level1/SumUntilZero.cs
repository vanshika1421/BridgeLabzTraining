
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SumUntilZero
    {
        public static void CalculateSumUntilZero()
        {
            double total = 0.0;
            double userInput;
            Console.WriteLine("Enter numbers to sum (enter 0 to stop):");
            while (true)
            {
                userInput = double.Parse(Console.ReadLine());
                if (userInput == 0)
                {
                    break;
                }
                total += userInput;
            }
            Console.WriteLine("The total sum of the entered numbers is: " + total);
        }
    }
}
