//Rewrite the above program using multi-dimensional array to store height, weight, and BMI in 2D array for all the persons
//Hint => 
//Take input for a number of persons
//Create a multi-dimensional array to store weight, height and BMI. Also create an to store the weight status of the persons
//       double[][] personData = new double[number][3];
//String[] weightStatus = new String[number];
//Take input for weight and height of the persons and for negative values, ask the user to enter positive values
//Calculate BMI of all the persons and store them in the personData array and also find the weight status and put them in the weightStatus array
//Display the height, weight, BMI and status of each person

using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays2
{
    internal class _2DArray_BMI
    {
        public static void _2DArray_BMIMethod()
        {
            Console.WriteLine("Enter the number of persons: ");
            int numberOfPersons = int.Parse(Console.ReadLine());
            double[][] personData = new double[numberOfPersons][];
            string[] weightStatus = new string[numberOfPersons];
            for (int i = 0; i < numberOfPersons; i++)
            {
                personData[i] = new double[3]; // 0: weight, 1: height, 2: BMI
                do
                {
                    Console.WriteLine("Enter the weight of person " + (i + 1) + " in kg: ");
                    personData[i][0] = double.Parse(Console.ReadLine());
                    if (personData[i][0] <= 0)
                    {
                        Console.WriteLine("Please enter a positive value for weight.");
                    }
                } while (personData[i][0] <= 0);
                do
                {
                    Console.WriteLine("Enter the height of person " + (i + 1) + " in meters: ");
                    personData[i][1] = double.Parse(Console.ReadLine());
                    if (personData[i][1] <= 0)
                    {
                        Console.WriteLine("Please enter a positive value for height.");
                    }
                } while (personData[i][1] <= 0);
                // Calculate BMI
                personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);
                // Determine weight status
                if (personData[i][2] < 18.5)
                {
                    weightStatus[i] = "Underweight";
                }
                else if (personData[i][2] >= 18.5 && personData[i][2] < 24.9)
                {
                    weightStatus[i] = "Normal weight";
                }
                else if (personData[i][2] >= 25 && personData[i][2] < 29.9)
                {
                    weightStatus[i] = "Overweight";
                }
                else
                {
                    weightStatus[i] = "Obesity";
                }
            }
            // Display results
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine($"Person {i + 1}: Height: {personData[i][1]} m, Weight: {personData[i][0]} kg, BMI: {personData[i][2]:F2}, Status: {weightStatus[i]}");
            }
        }
    }
}
