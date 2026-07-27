using System;

namespace Method_Level2
{
    internal class SumOfNumbers
    {
        // Recursive method
        public static int SumOfNaturalNumbersRecursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return n + SumOfNaturalNumbersRecursive(n - 1);
        }

        // Formula method
        public static int SumOfNaturalNumbersFormula(int n)
        {
            return n * (n + 1) / 2;
        }

        // Compare both results
        public static void CompareResults(int n)
        {
            int recursiveSum = SumOfNaturalNumbersRecursive(n);
            int formulaSum = SumOfNaturalNumbersFormula(n);

            Console.WriteLine("\nUsing Recursion : " + recursiveSum);
            Console.WriteLine("Using Formula   : " + formulaSum);

            if (recursiveSum == formulaSum)
            {
                Console.WriteLine("Both methods give the same result.");
            }
            else
            {
                Console.WriteLine("Results are different.");
            }
        }
    }
}