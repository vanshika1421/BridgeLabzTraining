//10.An organization took up the exercise to find the Body Mass Index (BMI) of all the persons in the team of 10 members. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
//Hint => 
//a.               Take user input in double for the weight (in kg) of the person and height (in cm) for the person and store it in the corresponding 2D array of 10 rows and 3 columns. The First Column storing the weight, the second column storing the height in cm and the third column is the BMI
//b.               Create a Method to find the BMI of every person and populate the array. Use the formula BMI = weight / (height * height). Note unit is kg/m^2. For this convert cm to meter
//c.                Create a Method to determine the BMI status using the logic shown in the figure below. and return the array of all the persons BMI Status. 


using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class BMI
    {
        public static double CalculateBMI(double weight, double heightInCm)
        {
            double heightInMeters = heightInCm / 100; // Convert cm to meters
            return weight / (heightInMeters * heightInMeters);
        }
        public static string DetermineBMIStatus(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }
        public static void DisplayResults(double[,] data)
        {
            Console.WriteLine("Weight (kg)\tHeight (cm)\tBMI\t\tStatus");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                double weight = data[i, 0];
                double height = data[i, 1];
                double bmi = data[i, 2];
                string status = DetermineBMIStatus(bmi);
                Console.WriteLine($"{weight}\t\t{height}\t\t{bmi:F2}\t\t{status}");
            }
        }
    }
}
