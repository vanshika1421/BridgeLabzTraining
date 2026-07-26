//Create a program to store the digits of the number in an array and find the largest and second largest element of the array.
//Hint => 
//Create a number variable and take user input. 
//Define an array to store the digits. Set the size of the array to maxDigit variable initially set to 10
//Create an integer variable index with the value 0 to reflect the array index.
//Use a loop to iterate until the number is not equal to 0.
//Remove the last digit from the number in each iteration and add it to the array.
//Increment the index by 1 in each iteration and if the index count equals maxDigit then break out of the loop and the remaining digits are not added to the array
//Define variable to store largest and second largest digit and initialize it to zero
//Loop through the array and use conditional statements to find the largest and second largest number in the array
//Finally display the largest  and second-largest number
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays2
{
    internal class LargestAndSecondLargest
    {
        public static void LargestAndSecondLargestMethod()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;
            while (number != 0)
            {
                digits[index] = number % 10;
                number /= 10;
                index++;
                if (index == maxDigit)
                {
                    break;
                }
            }
            int largest = 0;
            int secondLargest = 0;
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
            Console.WriteLine("The largest digit is: " + largest);
            Console.WriteLine("The second largest digit is: " + secondLargest);
        }
    }
}
