using System;
using System.IO;
namespace Level2;
public class FilterStudents
{
    public void Filter()
    {
        string fileName = "students.csv";

        string[] lines = File.ReadAllLines(fileName);

        Console.WriteLine("Students with marks greater than 80:");
        Console.WriteLine("-------------------------------------");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            int marks = int.Parse(data[3]);

            if (marks > 80)
            {
                Console.WriteLine(
                    $"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}"
                );
            }
        }
    }
}