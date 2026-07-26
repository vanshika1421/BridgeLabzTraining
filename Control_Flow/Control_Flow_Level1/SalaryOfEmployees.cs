using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SalaryOfEmployees
    {
        public static void EmployeeBonus()
        {
            Console.Write("Enter Employee Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Years of Service: ");
            int yearsOfService = Convert.ToInt32(Console.ReadLine());

            if (yearsOfService > 5)
            {
                double bonus = salary * 0.05;
                Console.WriteLine("Bonus Amount: " + bonus);
            }
            else
            {
                Console.WriteLine("Employee is not eligible for bonus.");
            }
        }
    }
}
