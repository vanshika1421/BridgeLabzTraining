//Write a Program to check if the given number is a prime number or not
//Hint => 
//A number that can be divided exactly only by itself and 1 are Prime Numbers,
//Prime Numbers checks are done for numbers greater than 1
//Loop through all the numbers from 2 to the user input number and check if the reminder is zero. If the reminder is zero break out from the loop as the number is divisible by some other number and is not a prime number. 
//Use isPrime boolean variable to store the result

using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level2
{
    internal class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            Console.WriteLine("Enter a number to check if it is a prime number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }
}
