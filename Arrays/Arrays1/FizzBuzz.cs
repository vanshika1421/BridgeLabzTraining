using System;

namespace Practice_Problems_Array
{
    internal class FizzBuzz
    {
      public  static void FizzbuzzArray()
        {
            Console.Write("Enter a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            string[] result = new string[number + 1];

            // Store values in the array
            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else
                {
                    result[i] = i.ToString();
                }
            }

            // Print the array
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("Position {0} = {1}", i, result[i]);
            }
        }
    }
}