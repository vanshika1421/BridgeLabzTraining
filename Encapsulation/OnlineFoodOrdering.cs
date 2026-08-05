
//6.Online Food Delivery System
//Description: Create an online food delivery system:
//Define an abstract class FoodItem with fields like itemName, price, and quantity.
//Add abstract methods CalculateTotalPrice() and concrete methods like GetItemDetails().
//Extend it into classes VegItem and NonVegItem, overriding CalculateTotalPrice() to include additional charges.
//Use an interface IDiscountable with methods ApplyDiscount() and GetDiscountDetails().
//Use polymorphism to handle different types of food items dynamically.


using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{

    internal abstract class foodItems
    {
        public string itemName { get; private set; } = string.Empty;
        public double Price { get; private set; }
        public int Quantity { get; private set; }
        public foodItems(string itemName , double Price , int Quantity) { 
            this.itemName = itemName;
            this.Price = Price;
            this.Quantity = Quantity;
        }
        public abstract double CalculateTotalPrice();
        public void getItemDetails()
        {
            Console.WriteLine($"Item Name : {itemName}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Quantity : {Quantity}");
        }


    }
    internal class VegItems : foodItems , IDiscountable
    {
        public VegItems(string itemName , double Price , int Quantity) : base(itemName , Price , Quantity) { }
        public override double CalculateTotalPrice()
        {
            return Price * Quantity + 100 ;
        }
        public double ApplyDiscount()
        {
            return 0.10 * (Price * Quantity);
        }
        public void GetDiscountDetails()
        {
            Console.WriteLine($"Discount of rupees {ApplyDiscount()} applied ");
            Console.WriteLine($"Total Payable amount is now {CalculateTotalPrice() - ApplyDiscount()}");
        }

    }
    internal class NonVegItems : foodItems , IDiscountable
    {
        public NonVegItems(string itemName, double Price, int Quantity) : base(itemName, Price, Quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return Price * Quantity + 200;
        }
        public double ApplyDiscount()
        {
            return Price * Quantity * 0.05;
        }
        public void GetDiscountDetails()
        {
            Console.WriteLine($"Discount of rupees {ApplyDiscount()} is applied" );
            Console.WriteLine($"Now payable amount is {CalculateTotalPrice() - ApplyDiscount()}");
        }
    }
    internal interface IDiscountable
    {
        double ApplyDiscount();
        void GetDiscountDetails();
    }
}

