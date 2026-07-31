//using System.Xml.Linq;

//Library Book System
//Create a Book class with attributes title, author, price, and availability.
//Implement a method BorrowBook() to borrow a book.


using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class LibraryMangement
    {
        String title;
        String author;
        double price;
        Boolean availability;
        public LibraryMangement()
        {
            title = "Oliver Twist";
            author = "abc";
            price = 160;
            availability = true;

        }
        public void BorrowBook()
        {
            if (availability)
            {
                availability = false;
                Console.WriteLine("Book Booking Successful");
            }
            else
            {
                Console.WriteLine("Sorry book not avaiable");
            }
        }
        
    }
}
