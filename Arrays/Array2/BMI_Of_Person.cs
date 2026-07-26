//An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in the team. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
//Hint => 
//Take input for a number of persons
//Create arrays to store the weight, height, BMI, and weight status of the persons
//Take input for the weight and height of the persons
//Calculate the BMI of all the persons and store them in an array and also find the weight status of the persons
//Display the height, weight, BMI, and weight status of each person
//Use the table to determine the weight status of the person


using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays2
{
    internal class BMI_Of_Person
    {
        public static void BMI_Of_PersonMethod()
        {
            Console.WriteLine("Enter the number of persons: ");
            int numberOfPersons = int.Parse(Console.ReadLine());
            double[] weight = new double[numberOfPersons];
            double[] height = new double[numberOfPersons];
            double[] bmi = new double[numberOfPersons];
            string[] status = new string[numberOfPersons];
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("Enter the weight of person " + (i + 1) + " in kg: ");
                weight[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of person " + (i + 1) + " in meters: ");
                height[i] = double.Parse(Console.ReadLine());
                bmi[i] = weight[i] / (height[i] * height[i]);
                if (bmi[i] < 18.5)
                {
                    status[i] = "Underweight";
                }
                else if (bmi[i] >= 18.5 && bmi[i] < 24.9)
                {
                    status[i] = "Normal weight";
                }
                else if (bmi[i] >= 25 && bmi[i] < 29.9)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obesity";
                }
            }
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("Person " + (i + 1) + ": Height: " + height[i] + " m, Weight: " + weight[i] + " kg, BMI: " + bmi[i].ToString("F2") + ", Status: " + status[i]);
            }
        }
    }
}
