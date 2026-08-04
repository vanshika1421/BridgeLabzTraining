//Sample Problem 1: Library Management with Books and Authors
//○ Description: Model a Book system where Book is the superclass, and Author
//is a subclass.
//○ Tasks:
//■ Define a superclass Book with attributes like Title and
//PublicationYear.
//■ Define a subclass Author with additional attributes like Name and Bio.
//■ Create a method DisplayInfo() to show details of the book and its
//author.
//○ Goal: Practice single inheritance by extending the base class and adding more
//specific details in the subclass.

using System;

namespace LibraryManagement
{
    // Base Class
    internal class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title            : {Title}");
            Console.WriteLine($"Publication Year : {PublicationYear}");
        }
    }

    // Derived Class
    internal class Author : Book
    {
        public string Name { get; set; }
        public string Bio { get; set; }

        public Author(string title, int publicationYear,
                      string name, string bio)
            : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author Name : {Name}");
            Console.WriteLine($"Bio         : {Bio}");
        }
    }

   
}
