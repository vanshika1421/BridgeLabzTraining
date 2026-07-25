using System;
using System.Collections.Generic;
using System.Text;
//6.The University is charging the student a fee of INR 125000 for the course. The University is willing to offer a discount of 10%. Write a program to find the discounted amount and discounted price the student will pay for the course.
//Hint:
//Create a variable named fee and assign 125000 to it.
//Create another variable discountPercent and assign 10 to it.
//Compute discount and assign it to the discount variable.
//Compute and print the fee you have to pay by subtracting the discount from the fee.
//I/P => NONE
//O/P => The discount amount is INR ___ and final discounted fee is INR ___

namespace Basic_Problems
{
    internal class DiscountAmount
    {
        public static void DiscountCalculation()
        {
            int fee = 125000;
            int discountPercent = 10;
            double discountAmount = (double)fee * discountPercent / 100;
            double finalFee = fee - discountAmount;
            Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {finalFee}");
        }
    }
}
