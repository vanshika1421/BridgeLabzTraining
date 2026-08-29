using System;
using System.IO;

public class ReadStudentCsv
{
    public void ReadFile()
    {
        string fileName = "students.csv";

        string[] lines = File.ReadAllLines(fileName);

        Console.WriteLine("STUDENT DETAILS");
        Console.WriteLine("-------------------------");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            Console.WriteLine(
                $"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}"
            );
        }
    }
}