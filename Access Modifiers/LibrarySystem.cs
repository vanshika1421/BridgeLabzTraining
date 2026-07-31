//Problem 2: Book Library System
//Design a Book class with :
//ISBN(public)
//title(protected)
//author(private)
//Implement methods to:
//Set and get the author name.
//Create a subclass EBook to access ISBN and title and demonstrate access modifiers.

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Access_Modifiers
{
    internal class Book
    {

        public int ISBN;
        private string author;
        protected string title;
        public Book()
        {
            ISBN = 0;
            author = "efg";
            title = "abc";

        }
        public Book(int ISBN, string author, string title)
        {
            this.ISBN = ISBN;
            this.author = author;
            this.title = title;
        }
        public void setAuthor(string author)
        {
            this.author = author;
        }
        public string getAuthor()
        {
            return author;
        }
    }


    internal class EBook : Book
    {
        public EBook(int ISBN, string author, string title) : base(ISBN, author, title)
        {
        }
        public void display()
        {
            Console.WriteLine("ISBN number is "+ ISBN);
            Console.WriteLine("Author name is " + getAuthor());
            Console.WriteLine("Title is "+ title);
        }
        


    }
}
