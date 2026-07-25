using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
//4.Create a program to calculate the profit and loss in number and percentage based on the cost price of INR 129 and the selling price of INR 191.
//Hint:
//Use a single print statement to display multiline text and variables.
//Profit = selling price - cost price
//Profit Percentage = profit / cost price * 100
//I/P => NONE
//O/P =>
//The Cost Price is INR ___ and Selling Price is INR ___
//The Profit is INR ___ and the Profit Percentage is ___

namespace Basic_Problems
{
    internal class ProfitLoss
    {
        public static void ProfitLossCalculation()
        {
            int costPrice = 129;
            int sellingPrice = 191;
            int profit = sellingPrice - costPrice;
            double profitPercentage = (double)profit / costPrice * 100;
            Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\n" +
                              $"The Profit is INR {profit} and the Profit Percentage is {profitPercentage}%");
        }
    }
}
