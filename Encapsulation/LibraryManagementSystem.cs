//using System.Runtime.Intrinsics.X86;

//5.Library Management System
//Description: Develop a library management system:
//Use an abstract class LibraryItem with fields like itemId, title, and author.
//Add an abstract method GetLoanDuration() and a concrete method GetItemDetails().
//Create subclasses Book, Magazine, and DVD, overriding GetLoanDuration() with specific logic.
//Implement an interface IReservable with methods ReserveItem() and CheckAvailability().
//Apply encapsulation to secure details like the borrower’s personal data.
//Use polymorphism to allow a general LibraryItem reference to manage all items.


using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    
        abstract class Library
        {
            public int itemId { get; private set; }
            public string title { get; private set; } = string.Empty;
            public string author { get; private set; } = string.Empty;
            public Library(int itemId, string title, string author)
            {
                this.itemId = itemId;
                this.title = title;
                this.author = author;
            }
            public abstract int GetLoanDuration();
            public void GetItemDetails()
            {
                Console.WriteLine($"Item ID: {itemId}");
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Author: {author}");
            }
            public void DisplayDetails()
            {
                GetItemDetails();
                Console.WriteLine($"Loan Duration: {GetLoanDuration()} days");

            }
        }
            class Book : Library, IReservable
            {
                public Book(int itemId, string title, string author) : base(itemId, title, author) { }
                public override int GetLoanDuration()
                {
                    return 14; // 14 days for books
                }
                public void ReserveItem()
                {
                    Console.WriteLine("Book reserved successfully.");
                }
                public bool CheckAvailability()
                {
                    return true; // Assume always available for simplicity
                }
            }
            class Magazine : Library, IReservable
            {
                public Magazine(int itemId, string title, string author) : base(itemId, title, author) { }
                public override int GetLoanDuration()
                {
                    return 7; // 7 days for magazines
                }
                public void ReserveItem()
                {
                    Console.WriteLine("Magazine reserved successfully.");
                }
                public bool CheckAvailability()
                {
                    return true; // Assume always available for simplicity
                }
            }
            class DVD : Library, IReservable
            {
                public DVD(int itemId, string title, string author) : base(itemId, title, author) { }
                public override int GetLoanDuration()
                {
                    return 3; // 3 days for DVDs
                }
                public void ReserveItem()
                {
                    Console.WriteLine("DVD reserved successfully.");
                }
                public bool CheckAvailability()
                {
                    return true; // Assume always available for simplicity
                }

            }
            interface IReservable
            {
                void ReserveItem();
                bool CheckAvailability();
            }
        }
    

