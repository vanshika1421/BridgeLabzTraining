//3.Creating and Handling a Custom Exception
//💡 Problem Statement:
//Create a custom exception called InvalidAgeException.
//Write a method ValidateAge(int age) that throws InvalidAgeException if the age is below 18.
//In Main(), take user input and call ValidateAge().
//If an exception occurs, display "Age must be 18 or above".


using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class CreatingAndHandlingCustomException
    {
        public void ValidateAge(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new InvalidAgeException("age must be atleast 18");
                }
                Console.WriteLine(age);
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
