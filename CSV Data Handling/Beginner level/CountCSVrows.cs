using System;
using System.IO;

public class CountCsvRows
{
    public void CountRows()
    {
        string fileName = "students.csv";

        string[] lines = File.ReadAllLines(fileName);

        int count = lines.Length - 1;

        Console.WriteLine($"Number of student records: {count}");
    }
}