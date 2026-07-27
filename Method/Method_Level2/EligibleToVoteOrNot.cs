//7.Write a program to take user input for the age of all 10 students in a class and check whether the student can vote depending on his/her age is greater or equal to 18.
//Hint => 
//a.               Create a class public class StudentVoteChecker and define a method public boolean CanStudentVote(int age) which takes in age as a parameter and returns true or false
//b.               Inside the method firstly validate the age for a negative number, if a negative return is false cannot vote. For valid age check for age is 18 or above return true; else return false;
//c.In the main function define an array of 10 integer elements, loop through the array by take user input for the student's age, call CanStudentVote() and display the result


using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class EligibleToVoteOrNot
    {
        public static bool CanStudentVote(int age)
        {
            if (age < 0)
            {
                return false; // Cannot vote for negative age
            }
            return age >= 18; // Return true if age is 18 or above, else false
        }
        public static void CheckVotingEligibility()
        {
            int[] studentAges = new int[10];
            for (int i = 0; i < studentAges.Length; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                studentAges[i] = int.Parse(Console.ReadLine());
                bool canVote = CanStudentVote(studentAges[i]);
                if (canVote)
                {
                    Console.WriteLine($"Student {i + 1} can vote.");
                }
                else
                {
                    Console.WriteLine($"Student {i + 1} cannot vote.");
                }
            }
        }
       
    }
}
