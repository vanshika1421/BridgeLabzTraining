using System;

namespace Method_Level2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] factors = FindFactors.GetFactors(number);

            FindFactors.DisplayResults(factors);

            Console.ReadLine();
        }
    }
}