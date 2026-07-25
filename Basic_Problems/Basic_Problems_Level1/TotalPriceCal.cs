using System;
using System.Collections.Generic;
using System.Text;
//15.Write a program to input the unit price of an item and the quantity to be bought. Then, calculate the total price.
//Hint: NA
//I/P => unitPrice, quantity
//O/P => The total purchase price is INR ___ if the quantity ___ and unit price is INR ___


namespace Basic_Problems
{
    internal class TotalPriceCal
    {
        public static void TotalPriceCalculation()
        {
            Console.WriteLine("Enter the unit price of the item: ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity to be bought: ");
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = unitPrice * quantity;
            Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity {quantity} and unit price is INR {unitPrice}");
        }
    }
}
