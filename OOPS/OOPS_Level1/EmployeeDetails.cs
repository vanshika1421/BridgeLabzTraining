//Level 1 Practice Programs
//1. Program to Display Employee Details
//Problem Statement: Write a program to create an Employee class with attributes name, id, and salary. Add a method to display the details.


using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class EmployeeDetails
    {
        public String name ;
        public int id;
        public double salary;

        public EmployeeDetails(String name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public  void displayDetails()
        {
            Console.WriteLine("Name is "+name);
            Console.WriteLine("Id is "+id);
            Console.WriteLine("Salary is "+salary);
        }

    }
}
