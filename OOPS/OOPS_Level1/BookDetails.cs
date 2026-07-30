using System.Xml.Linq;

//3.Program to Handle Book Details
//Problem Statement: Write a program to create a Book class with attributes title, author, and price. Add a method to display the book details.

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class BookDetails
    {
        public string title;
        public string author;
        public double price;
        public BookDetails(string title , string author , double price) 
        {
            this.price = price;
            this.title = title;
            this.author = author;
        }
        public void displayDetails()
        {
            Console.WriteLine($"Title of the books is {title}");
            Console.WriteLine($"It is written by {author} ");
            Console.WriteLine($"Price of the books is {price:F4}");
        }
    }
}
