//Problem 1: University Management System
//Create a Student class with :
//rollNumber(public)
//name(protected)
//CGPA(private)
//Implement methods to:
//Access and modify CGPA using public methods.
//Create a subclass PostgraduateStudent to demonstrate the use of protected members.


using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    internal class UniversityManagement
    {
        public int rollNumber;
        protected string name;
        private float cgpa;
        public UniversityManagement()
        {
            rollNumber = 0;
            name = "abc";
            cgpa = 0.0f;
        }
        public UniversityManagement(int rollNumber, string name, float cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;

        }
        public void setCgpa(float cgpa)
        {
            this.cgpa = cgpa;
        }
        public float getCgpa()
        {
            return cgpa;

        }

    }
    internal class PostgraduateStudents : UniversityManagement
    {
       
            public PostgraduateStudents(String name , int rollNumber , float cgpa)
            
                : base(rollNumber, name, cgpa)
        {

            }
        public void displayDetails()
        {
            Console.WriteLine("Name is : "+ name);
            Console.WriteLine("rollNumber is : "+ rollNumber);
            Console.WriteLine("Cgpa is :" + getCgpa());

           
        }
        }
    
}
