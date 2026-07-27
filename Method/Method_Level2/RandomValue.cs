using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class RandomValue
    {
        // Method to generate random 4-digit numbers
        public static int[] Generate4DigitRandomArray(int size)
        {
            Random random = new Random();
            int[] randomNumbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                randomNumbers[i] = random.Next(1000, 10000);
            }

            return randomNumbers;
        }

        // Method to find Average, Minimum and Maximum
        public static double[] FindAverageMinMax(int[] numbers)
        {
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            foreach (int number in numbers)
            {
                sum += number;

                min = Math.Min(min, number);
                max = Math.Max(max, number);
            }

            double average = (double)sum / numbers.Length;

            return new double[] { average, min, max };
        }

        // Driver Method
        public static void RandomNumbers()
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = Generate4DigitRandomArray(size);

            Console.WriteLine("\nGenerated Random Numbers:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            double[] result = FindAverageMinMax(numbers);

            Console.WriteLine("\nAverage = " + result[0]);
            Console.WriteLine("Minimum = " + result[1]);
            Console.WriteLine("Maximum = " + result[2]);
        }
    }
}