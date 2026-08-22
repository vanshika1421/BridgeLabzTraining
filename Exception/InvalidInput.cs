//using System.Reflection.Metadata;

//6.Handling Invalid Input in Interest Calculation
//💡 Problem Statement:
//Create a method CalculateInterest(double amount, double rate, int years) that:
//Throws ArgumentException if amount or rate is negative.
//Propagates the exception using throw and handles it in Main().
//Expected Behavior:
//If valid, return and print the calculated interest.
//If invalid, catch and display "Invalid input: Amount and rate must be positive".


using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class InvalidInput
    {
        public void InputCheck(int amount)
        {
            try
            {
                if(amount < 0)
                {
                    throw new InvalidInputException("Amount cant be negative");
                }
                Console.WriteLine(amount);
            }
            catch(InvalidInputException e) {
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
