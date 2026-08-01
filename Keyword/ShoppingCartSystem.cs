//Sample Program 4: Shopping Cart System
//Create a Product class to manage shopping cart items with the following features:
//static: 
//A static variable Discount shared by all products.
//A static method UpdateDiscount() to modify the discount percentage.
//this: 
//Use this to initialize ProductName, Price, and Quantity in the constructor.
//readonly: 
//Use a readonly variable ProductID to ensure each product has a unique identifier that cannot be changed.
//is operator: 
//Validate whether an object is an instance of the Product class before processing its details.

using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    
        internal class Product
        {
            // Static Variables
            public static double Discount = 10; // 10%
            public static int TotalProducts = 0;

            // Readonly Variable
            public readonly int ProductID;

            // Instance Variables
            string ProductName;
            double Price;
            int Quantity;

            // Constructor
            public Product(int productID, string productName, double price, int quantity)
            {
                this.ProductID = productID;
                this.ProductName = productName;
                this.Price = price;
                this.Quantity = quantity;

                TotalProducts++;
            }

            // Static Method
            public static void UpdateDiscount(double newDiscount)
            {
                Discount = newDiscount;
            }

            // Display Product Details
            public void DisplayProductDetails()
            {
                double totalPrice = Price * Quantity;
                double finalPrice = totalPrice - (totalPrice * Discount / 100);

                Console.WriteLine("Product ID   : " + ProductID);
                Console.WriteLine("Product Name : " + ProductName);
                Console.WriteLine("Price        : " + Price);
                Console.WriteLine("Quantity     : " + Quantity);
                Console.WriteLine("Discount     : " + Discount + "%");
                Console.WriteLine("Final Price  : " + finalPrice);
            }
        }

    }

