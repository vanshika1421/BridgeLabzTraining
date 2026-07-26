using System;

namespace Arrays2
{
    internal class GradesCalculation2D
    {
        public static void GradesCalculationMethod()
        {
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            // Rows = Students, Columns = Subjects
            // Column 0 = Physics
            // Column 1 = Chemistry
            // Column 2 = Maths
            double[,] marks = new double[numberOfStudents, 3];

            double[] percentages = new double[numberOfStudents];
            string[] grades = new string[numberOfStudents];

            // Input Marks
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nEnter marks for Student {i + 1}");

                Console.Write("Physics: ");
                marks[i, 0] = double.Parse(Console.ReadLine());

                Console.Write("Chemistry: ");
                marks[i, 1] = double.Parse(Console.ReadLine());

                Console.Write("Maths: ");
                marks[i, 2] = double.Parse(Console.ReadLine());

                // Check for negative marks
                if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
                {
                    Console.WriteLine("Marks cannot be negative. Please enter again.");
                    i--;
                    continue;
                }

                // Calculate Percentage
                percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

                // Calculate Grade
                if (percentages[i] >= 90)
                    grades[i] = "A";
                else if (percentages[i] >= 80)
                    grades[i] = "B";
                else if (percentages[i] >= 70)
                    grades[i] = "C";
                else if (percentages[i] >= 60)
                    grades[i] = "D";
                else
                    grades[i] = "F";
            }

            Console.WriteLine("\nStudent Details");

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("\nStudent " + (i + 1));
                Console.WriteLine("Physics Marks: " + marks[i, 0]);
                Console.WriteLine("Chemistry Marks: " + marks[i, 1]);
                Console.WriteLine("Maths Marks: " + marks[i, 2]);
                Console.WriteLine("Percentage: " + percentages[i]);
                Console.WriteLine("Grade: " + grades[i]);
            }
        }
    }
}