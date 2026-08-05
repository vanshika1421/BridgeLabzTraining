//using System.Runtime.Intrinsics.X86;

//1.Employee Management System

//Description: Build an employee management system with the following requirements:
//Use an abstract class Employee with fields like employeeId, name, and baseSalary.
//Provide an abstract method CalculateSalary() and a concrete method DisplayDetails().
//Create two subclasses: FullTimeEmployee and PartTimeEmployee, implementing CalculateSalary() based on work hours or fixed salary.
//Use encapsulation to restrict direct access to fields and provide properties for access.
//Create an interface IDepartment with methods like AssignDepartment() and GetDepartmentDetails().
//Ensure polymorphism by processing a list of employees and displaying their details using the Employee reference.

using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal abstract class Employee
    {

        public int EmployeeID { get; set; }
        public string Name { get; set; }
        protected double BaseSalary { get; set; }
        public Employee(int employeeID, String name, double baseSalary)
        {
            EmployeeID = employeeID;
            Name = name;
            BaseSalary = baseSalary;
        }
        public abstract double CalculateSalary();
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}, Name: {Name},   Salary: {CalculateSalary()}");
        }
        //public double getBaseSalary()
        //{
        //    return baseSalary;
        //}
    }
    internal class FulltimeEmployee : Employee , IDepartment

    {
        double fixedSalary;

        public FulltimeEmployee(int employeeID, String name, double baseSalary, double fixedSalary) : base(employeeID, name, baseSalary)
        {
            this.fixedSalary = fixedSalary;
        }
        
        public void AssignDepartment(string departmentName)
        {
            Console.WriteLine($"Employee {Name} assigned to department: {departmentName}");
        }
        public string GetDepartmentDetails()
        {
            return $"Employee {Name} is in the department.";
        }

        public override double CalculateSalary()
        {
            return fixedSalary + BaseSalary;
        }

    }
    internal class PartTimeEmployee : Employee , IDepartment
    {
      public PartTimeEmployee(int employeeID, String name, double baseSalary, int workHours, double perHourRate) : base(employeeID, name, baseSalary)
        {
            this.workHours = workHours;
            this.perHourRate = perHourRate;
        }
        public void AssignDepartment(string departmentName)
        {
            Console.WriteLine($"Employee {Name} assigned to department: {departmentName}");
        }
        public string GetDepartmentDetails()
        {
            return $"Employee {Name} is in the department.";
        }
        int workHours;
        double perHourRate;
        public override double CalculateSalary()
        {
            return (perHourRate * workHours) + BaseSalary;
        }
    }
    interface IDepartment
    {
        void AssignDepartment(string departmentName);
        string GetDepartmentDetails();
    }
}
