using System;
using System.IO;
using System.Linq;
namespace Level2;

public class SortEmployees
{
    public void Sort()
    {
        string fileName = "employees.csv";

        string[] lines = File.ReadAllLines(fileName);

        var employees = lines
            .Skip(1)
            .Select(line =>
            {
                string[] data = line.Split(',');

                return new
                {
                    ID = data[0],
                    Name = data[1],
                    Department = data[2],
                    Salary = double.Parse(data[3])
                };
            })
            .OrderByDescending(e => e.Salary)
            .Take(5);

        Console.WriteLine("Top 5 Highest-Paid Employees");
        Console.WriteLine("-----------------------------");

        foreach (var employee in employees)
        {
            Console.WriteLine(
                $"ID: {employee.ID}, " +
                $"Name: {employee.Name}, " +
                $"Department: {employee.Department}, " +
                $"Salary: {employee.Salary}"
            );
        }
    }
}