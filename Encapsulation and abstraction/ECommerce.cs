
//2.E - Commerce Platform
//Description: Develop a simplified e-commerce platform:
//Create an abstract class Product with fields like productId, name, and price, and an abstract method CalculateDiscount().
//Extend it into concrete classes: Electronics, Clothing, and Groceries.
//Implement an interface ITaxable with methods CalculateTax() and GetTaxDetails() for applicable product categories.
//Use encapsulation to protect product details, allowing updates only through setter methods.
//Showcase polymorphism by creating a method that calculates and prints the final price (price + tax - discount) for a list of products.
////Using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal abstract class Product
    {
        public Product(int productId, string name, double price)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Price = price;
        }
        public int ProductId {  get; private set; }
        public string Name { get; private set; } = string.Empty;
        public double Price { get;  private set; }
        public abstract double CalculateDiscount();
        public void displayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: {Price}");
        }
    }
    internal class Electronics : Product , ITaxable
    {
        public Electronics(int productId, string name, double price) : base(productId, name, price)
        {
        }   
        public override double CalculateDiscount()
        {

            return Price *0.10+5;
        }
        public double CalculateTax()
        {
            // Implement tax calculation logic for electronics
            return Price * 0.17;
        }
        public string GetTaxDetails()
        {
            // Implement logic to return tax details for electronics
            return "Electronics Tax Details"; // Placeholder
        }
    }
    internal class Clothing : Product , ITaxable
    {
        public Clothing(int productId, string name, double price) : base(productId, name, price)
        {
        }
        public override double CalculateDiscount()
        {
            // Implement discount calculation logic for clothing
            return Price * 0.30; // Placeholder
        }
        public double CalculateTax()
        {
            // Implement tax calculation logic for clothing
            return Price * 0.20; // Placeholder
        }
        public string GetTaxDetails()
        {
            // Implement logic to return tax details for clothing
            return "Clothing Tax Details"; // Placeholder
        }

    }
    internal class Groceries : Product , ITaxable
    {
        public Groceries(int productId, string name, double price) : base(productId, name, price)
        {
        }   
        public override double CalculateDiscount()
        {
            // Implement discount calculation logic for groceries
            return Price * 0.10; // Placeholder
        }
        public double CalculateTax()
        {
            // Implement tax calculation logic for groceries
            return Price * 0.18;
        }
        public string GetTaxDetails()
        {
            // Implement logic to return tax details for groceries
            return "Groceries Tax Details"; // Placeholder
        }
    }
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}
