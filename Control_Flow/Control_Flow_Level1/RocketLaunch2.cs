using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class RocketLaunch2
    {
        public static void CountDownForRocketLaunch()
        {
            Console.WriteLine("Enter a number to start the countdown for rocket launch");
            int counter = int.Parse(Console.ReadLine());
           for(int i = counter; i>=1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Rocket Launched!");
        }
    }
}
