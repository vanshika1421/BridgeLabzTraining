//2.Doubly Linked List: Movie Management System
//Problem Statement: Implement a movie management system using a doubly linked list. Each node will represent a movie and contain Movie Title, Director, Year of Release, and Rating. Implement the following functionalities:
//Add a movie record at the beginning, end, or at a specific position.
//Remove a movie record by Movie Title.
//Search for a movie record by Director or Rating.
//Display all movie records in both forward and reverse order.
//Update a movie's Rating based on the Movie Title.

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class Movie_Management_System
    {

    }

   internal class Movie
    {
        public string title;
        public string Director;
            public int year_Of_release;
        public int rating;
        Movie next = null;
        public Movie(string title, string director, int year_Of_release , int rating)
        {
            this.title = title;
            Director = director;
            this.year_Of_release = year_Of_release;
            this.rating = rating;
        }


    }
}
