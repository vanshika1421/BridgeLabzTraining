using System;

class Program
{
    static void Main()
    {
        // Question 1
        ReadStudentCsv student = new ReadStudentCsv();
        student.ReadFile();

        Console.WriteLine();

        // Question 2
        WriteEmployeeCsv employee = new WriteEmployeeCsv();
        employee.WriteFile();

        Console.WriteLine();

        // Question 3
        CountCsvRows count = new CountCsvRows();
        count.CountRows();
    }
}