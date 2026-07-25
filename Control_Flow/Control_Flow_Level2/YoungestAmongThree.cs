//5.Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights

//Hint => 
//Take user input for the age and height of the 3 friends and store it in a variable
//Find the smallest of the 3 ages to find the youngest friend and display it
//Find the largest of the 3 heights to find the tallest friend and display it

using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level2
{
    internal class YoungestAmongThree
    {
        public static void FindYoungestAndTallest()
        {
            Console.WriteLine("Enter the age of Amar:");
            int ageAmar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of Amar (in cm):");
            int heightAmar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the age of Akbar:");
            int ageAkbar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of Akbar (in cm):");
            int heightAkbar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the age of Anthony:");
            int ageAnthony = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of Anthony (in cm):");
            int heightAnthony = Convert.ToInt32(Console.ReadLine());
            // Finding the youngest
            int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
            string youngestFriend = youngestAge == ageAmar ? "Amar" : youngestAge == ageAkbar ? "Akbar" : "Anthony";
            // Finding the tallest
            int tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
            string tallestFriend = tallestHeight == heightAmar ? "Amar" : tallestHeight == heightAkbar ? "Akbar" : "Anthony";
            Console.WriteLine($"The youngest friend is: {youngestFriend} with age {youngestAge}");
            Console.WriteLine($"The tallest friend is: {tallestFriend} with height {tallestHeight} cm");
        }
    }
}
