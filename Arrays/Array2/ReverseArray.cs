using System;

namespace Arrays2
{
    internal class ReverseNumberUsingArray
    {
        public static void ReverseNumber()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int temp = number;
            int count = 0;

            // Count the number of digits
            while (temp != 0)
            {
                count++;
                temp /= 10;
            }

            int[] digits = new int[count];

            temp = number;

            // Store digits in the array
            for (int i = 0; i < count; i++)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }

            int[] reverse = new int[count];

            // Store digits in reverse order
            for (int i = 0; i < count; i++)
            {
                reverse[i] = digits[count - 1 - i];
            }

            Console.Write("Reversed Number: ");

            // Display the reversed array
            for (int i = 0; i < count; i++)
            {
                Console.Write(reverse[i]);
            }

            Console.WriteLine();
        }
    }
}