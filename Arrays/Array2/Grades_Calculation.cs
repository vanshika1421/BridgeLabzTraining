//Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the percentage and then calculate the grade  as per the following guidelines 
//Hint =>
//Take input for the number of students
//Create arrays to store marks, percentages, and grades of the students
//Take input for marks of students in physics, chemistry, and maths. If the marks are negative, ask the user to enter positive values and decrement the index
//Calculate the percentage and grade of the students based on the percentage
//Display the marks, percentages, and grades of each student


using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays2
{
    internal class Grades_Calculation
    {
        public static void Grades_CalculationMethod()
        {
            Console.WriteLine("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            double[] physicsMarks = new double[numberOfStudents];
            double[] chemistryMarks = new double[numberOfStudents];
            double[] mathsMarks = new double[numberOfStudents];
            double[] percentages = new double[numberOfStudents];
            string[] grades = new string[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                do
                {
                    Console.WriteLine("Enter the marks of student " + (i + 1) + " in Physics: ");
                    physicsMarks[i] = double.Parse(Console.ReadLine());
                    if (physicsMarks[i] < 0)
                    {
                        Console.WriteLine("Please enter a positive value for marks.");
                    }
                } while (physicsMarks[i] < 0);
                do
                {
                    Console.WriteLine("Enter the marks of student " + (i + 1) + " in Chemistry: ");
                    chemistryMarks[i] = double.Parse(Console.ReadLine());
                    if (chemistryMarks[i] < 0)
                    {
                        Console.WriteLine("Please enter a positive value for marks.");
                    }
                } while (chemistryMarks[i] < 0);
                do
                {
                    Console.WriteLine("Enter the marks of student " + (i + 1) + " in Maths: ");
                    mathsMarks[i] = double.Parse(Console.ReadLine());
                    if (mathsMarks[i] < 0)
                    {
                        Console.WriteLine("Please enter a positive value for marks.");
                    }
                } while (mathsMarks[i] < 0);
                // Calculate percentage
                percentages[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i]) / 3;
                // Determine grade
                if (percentages[i] >= 90)
                {
                    grades[i] = "A";
                }
                else if (percentages[i] >= 80)
                {
                    grades[i] = "B";
                }
                else if (percentages[i] >= 70)
                {
                    grades[i] = "C";
                }
                else if (percentages[i] >= 60)
                {
                    grades[i] = "D";
                }
                else
                {
                    grades[i] = "F";
                }
            }
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Student " + (i + 1));
                Console.WriteLine("Physics Marks: " + physicsMarks[i]);
                Console.WriteLine("Chemistry Marks: " + chemistryMarks[i]);
                Console.WriteLine("Maths Marks: " + mathsMarks[i]);
                Console.WriteLine("Percentage: " + percentages[i]);
                Console.WriteLine("Grade: " + grades[i]);
                Console.WriteLine();
            }
        }
    }
}