//Problem 1: Product Inventory
//Create a Product class with :
//Instance Variables: productName, price.
//Class Variable: totalProducts(shared among all products).
//Implement the following methods:
//An instance method DisplayProductDetails() to display the details of a product.
//A class method DisplayTotalProducts() to show the total number of products created.


using System;
using System.Collections.Generic;
using System.Text;

namespace Instance_vs._Class_Variables_and_Methods
{
    internal class Product
    {
        string ProductName;
        double price;
        static int totalProducts;
        public Product(string ProductName , double price ) {  
            this.ProductName = ProductName;
            this.price = price;
            totalProducts++;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Product name is {ProductName}");
            Console.WriteLine($"Price is {price}");
            Console.WriteLine(totalProduct());
        }
        public static int totalProduct()
        {
            return totalProducts;
        }
    }
}
