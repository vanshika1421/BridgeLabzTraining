using System;

namespace Practice_Problems_Array
{
    internal class OddEven
    {
        public static void OddEvenArray()
        {
            Console.Write("Enter a natural number: ");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            if (number <= 0)
            {
                Console.WriteLine("Please enter a natural number greater than 0.");
                return;
            }

            // Maximum possible odd/even numbers
            int[] oddNumbers = new int[number / 2 + 1];
            int[] evenNumbers = new int[number / 2 + 1];

            int oddIndex = 0;
            int evenIndex = 0;

            // Store odd and even numbers
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    oddNumbers[oddIndex] = i;
                    oddIndex++;
                }
            }

            // Print odd numbers
            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(oddNumbers[i] + " ");
            }

            // Print even numbers
            Console.WriteLine("\n\nEven Numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.Write(evenNumbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}