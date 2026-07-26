using System;

namespace Arrays2
{
    internal class LargestAndSecondLargest2
    {
        public static void FindLargestAndSecondLargest()
        {
            Console.Write("Enter a number: ");
            long number = long.Parse(Console.ReadLine());

            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;

            // Store digits in the array
            while (number != 0)
            {
                // Resize the array if it is full
                if (index == maxDigit)
                {
                    maxDigit += 10;

                    int[] temp = new int[maxDigit];

                    for (int i = 0; i < digits.Length; i++)
                    {
                        temp[i] = digits[i];
                    }

                    digits = temp;
                }

                digits[index] = (int)(number % 10);
                number /= 10;
                index++;
            }

            int largest = -1;
            int secondLargest = -1;

            // Find largest and second largest digit
            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }

            Console.WriteLine("\nDigits stored in the array:");
            for (int i = 0; i < index; i++)
            {
                Console.Write(digits[i] + " ");
            }

            Console.WriteLine($"\nLargest Digit: {largest}");

            if (secondLargest == -1)
            {
                Console.WriteLine("Second Largest Digit: Not Available");
            }
            else
            {
                Console.WriteLine($"Second Largest Digit: {secondLargest}");
            }
        }
    }
}