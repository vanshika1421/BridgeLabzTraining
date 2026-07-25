

//Write a program to count down the number from the user input value to 1 using a while loop for a rocket launch
//Hint =>
//Create a variable counter to take user inputted value for the countdown.
//Use the while loop to check if the counter is 1
//Inside a while loop, print the value of the counter and decrement the counter.
using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class RocketCountdown
    {
        public static void CountDownForRocketLaunch()
        {
            Console.WriteLine("Enter a number to start the countdown for rocket launch");
            int counter = int.Parse(Console.ReadLine());
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--;
            }
            Console.WriteLine("Rocket Launched!");
        }
    }
}
