using System;

namespace Practice_Problems_Array
{
    internal class FactorsOfNumber
    {
        public static void FindFactors()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return;
            }

            int maxFactor = 10;
            int[] factors = new int[maxFactor];
            int index = 0;

            // Find factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    // Increase array size if full
                    if (index == maxFactor)
                    {
                        maxFactor *= 2;
                        int[] temp = new int[maxFactor];

                        for (int j = 0; j < factors.Length; j++)
                        {
                            temp[j] = factors[j];
                        }

                        factors = temp;
                    }

                    factors[index] = i;
                    index++;
                }
            }

            // Display factors
            Console.WriteLine("\nFactors of " + number + " are:");

            for (int i = 0; i < index; i++)
            {
                Console.Write(factors[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
