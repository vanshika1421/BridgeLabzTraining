//Create a program to check if a number taken from the user is a Harshad Number.
//Hint => 
//A Harshad number is an integer which is divisible by the sum of its digits. 
//For example, 21 which is perfectly divided by 3 (sum of digits: 2 + 1).
//Get an integer input for the number variable.
//Create an integer variable sum with initial value 0.
//Create a while loop to access each digit of the number.
//Inside the loop, add each digit of the number to sum.
//Check if the number is perfectly divisible by the sum.
//If the number is divisible by the sum, print Harshad Number. Otherwise, print Not a Harshad Number.

using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3
{
    internal class HarshadNumber
    {
        public static void CheckHarshadNumber()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            if (originalNumber % sum == 0)
            {
                Console.WriteLine($"{originalNumber} is a Harshad Number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not a Harshad Number.");
            }
        }
    }
}
