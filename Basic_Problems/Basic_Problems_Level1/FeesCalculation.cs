using Basic_Problems;
using System;
using System.Collections.Generic;
using System.Text;


//9.Write a new program similar to the program # 6 but take user input for Student Fee and University Discount
//Hint:
//Create a variable named fee and take user input for fee.
//Create another variable discountPercent and take user input.
//Compute the discount and assign it to the discount variable.
//Compute and print the fee you have to pay by subtracting the discount from the fee.
//I/P => fee, discountPrecent
//O/P => The discount amount is INR ___ and final discounted fee is INR ___


namespace Basic_Problems
{
    internal class FeesCalculation
    {
        public static void FeesCalculationMethod()
        {
            Console.WriteLine("Enter the student fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the university discount percentage: ");
            double discountPercent = Convert.ToDouble(Console.ReadLine());
            double discountAmount = fee * discountPercent / 100;
            double finalFee = fee - discountAmount;
            Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {finalFee}");
        }
    }
}
