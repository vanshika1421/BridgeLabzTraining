

//Sample Program 3: Employee Management System
//Design an Employee
//    class with the following features:
//static: 
//A static variable CompanyName shared by all employees.
//A static method DisplayTotalEmployees() to show the total number of employees.
//this: 
//Use this to initialize Name, Id, and Designation in the constructor.
//readonly: 
//Use a readonly variable Id for the employee ID, which cannot be modified after assignment.
//is operator: 
//Check if a given object is an instance of the Employee class before printing the employee details.
using System;
namespace Keyword
{
    internal class Employee
    {
        // Static Variables
        public static string CompanyName = "OpenAI";
        public static int TotalEmployees = 0;

        // Readonly Variable
        public readonly int Id;

        // Instance Variables
        string Name;
        string Designation;

        // Constructor
        public Employee(int id, string name, string designation)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;

            TotalEmployees++;
        }

        // Static Method
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Company Name : " + CompanyName);
            Console.WriteLine("Total Employees : " + TotalEmployees);
        }

        // Instance Method
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID : " + Id);
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Designation : " + Designation);
        }
    }
}