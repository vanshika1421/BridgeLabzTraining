using System;
using System.IO;

public class WriteEmployeeCsv
{
    public void WriteFile()
    {
        string fileName = "employees.csv";

        string[] employees =
        {
            "ID,Name,Department,Salary",
            "101,Aarav,IT,50000",
            "102,Priya,HR,45000",
            "103,Rahul,Finance,55000",
            "104,Ananya,IT,60000",
            "105,Vansh,Marketing,48000"
        };

        File.WriteAllLines(fileName, employees);

        Console.WriteLine("Employee CSV file created successfully.");
    }
}