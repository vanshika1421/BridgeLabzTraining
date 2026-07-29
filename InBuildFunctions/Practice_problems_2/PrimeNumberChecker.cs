using System;

namespace Functions
{
    internal class PrimeNumberChecker
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine(number + " is a Prime Number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Prime Number.");
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}