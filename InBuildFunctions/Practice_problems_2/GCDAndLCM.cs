using System;

namespace Functions
{
    internal class GCDAndLCM
    {
        public static void Run()
        {
            int num1 = GetNumber("Enter the first number: ");
            int num2 = GetNumber("Enter the second number: ");

            int gcd = FindGCD(num1, num2);
            int lcm = FindLCM(num1, num2);

            Console.WriteLine("GCD = " + gcd);
            Console.WriteLine("LCM = " + lcm);
        }

        // Method to take input
        public static int GetNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        // Method to find GCD using Euclid's Algorithm
        public static int FindGCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
            }

            return num1;
        }

        // Method to find LCM
        public static int FindLCM(int num1, int num2)
        {
            return (num1 * num2) / FindGCD(num1, num2);
        }
    }
}