using System;
namespace Keyword
{
    internal class Book
    {
        // Static variable
        public static string LibraryName = "Central Library";

        // Readonly variable
        public readonly string ISBN;

        // Instance variables
        string Title;
        string Author;

        // Constructor
        public Book(string title, string author, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
        }

        // Static method
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name : " + LibraryName);
        }

        // Instance method
        public void DisplayBookDetails()
        {
            Console.WriteLine("Title  : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("ISBN   : " + ISBN);
        }
    }
}