using System;
using System.Collections.Generic;
using System.IO;

namespace Level2;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public void Display()
    {
        Console.WriteLine(
            $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}"
        );
    }
}

public class ConvertCsvToStudent
{
    public void Convert()
    {
        string fileName = "students.csv";

        string[] lines = File.ReadAllLines(fileName);

        List<Student> students = new List<Student>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            Student student = new Student
            {
                ID = int.Parse(data[0]),
                Name = data[1],
                Age = int.Parse(data[2]),
                Marks = int.Parse(data[3])
            };

            students.Add(student);
        }

        foreach (Student student in students)
        {
            student.Display();
        }
    }
}