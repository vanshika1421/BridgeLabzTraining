using System;
using System.IO;
namespace Level2;

public class UpdateEmployeeSalary
{
    public void UpdateSalary()
    {
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";

        string[] lines = File.ReadAllLines(inputFile);

        string[] updatedLines = new string[lines.Length];

        // Copy header
        updatedLines[0] = lines[0];

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            string department = data[2];

            if (department == "IT")
            {
                double salary = double.Parse(data[3]);

                salary = salary + (salary * 0.10);

                data[3] = salary.ToString();
            }

            updatedLines[i] = string.Join(",", data);
        }

        File.WriteAllLines(outputFile, updatedLines);

        Console.WriteLine(
            $"Updated records saved to {outputFile}"
        );
    }
}