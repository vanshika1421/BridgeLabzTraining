using System;

namespace Functions
{
    internal class FibonacciSequence
    {
        public static void Run()
        {
            Console.Write("Enter the number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            PrintFibonacci(terms);
        }

        // Method to print Fibonacci sequence
        public static void PrintFibonacci(int terms)
        {
            int first = 0;
            int second = 1;

            Console.WriteLine("Fibonacci Sequence:");

            for (int i = 1; i <= terms; i++)
            {
                Console.Write(first + " ");

                int next = first + second;
                first = second;
                second = next;
            }
        }
    }
}