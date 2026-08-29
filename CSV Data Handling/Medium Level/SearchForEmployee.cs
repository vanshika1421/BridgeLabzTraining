using System;
using System.IO;
namespace Level2;

public class SearchEmployee
{
    public void Search()
    {
        string fileName = "employees.csv";

        string[] lines = File.ReadAllLines(fileName);

        Console.Write("Enter employee name: ");
        string searchName = Console.ReadLine();

        bool found = false;

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            string name = data[1];

            if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nEmployee Found!");
                Console.WriteLine($"Department: {data[2]}");
                Console.WriteLine($"Salary: {data[3]}");

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Employee not found.");
        }
    }
}