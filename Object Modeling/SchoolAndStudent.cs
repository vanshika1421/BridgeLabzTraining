//Problem 1: School and Students with Courses (Association and Aggregation)
//Description: Model a School with multiple Student objects, where each student can enroll in multiple courses, and each course can have multiple students.
//Tasks:
//Define School, Student, and Course classes.
//Model an association between Student and Course to show that students can enroll in multiple courses.
//Model an aggregation relationship between School and Student.
//Demonstrate how a student can view the courses they are enrolled in and how a course can show its enrolled students.
//Goal: Practice association by modeling many-to-many relationships between students and courses.


using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Modeling
{
    internal class School
    {
        public string SchoolName;
       public List<Student> Students = new List<Student>();
        public School(string SchoolName)
        {
            this.SchoolName = SchoolName;
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        } 
        public void showStudents()
        {
            Console.WriteLine("Students in " + SchoolName + ":");
            foreach (Student s in Students)
            {
                Console.WriteLine(s.StudentName);
            }
        }
    }
    internal class Student
    {
        public string StudentName;
        List<Course> courses = new List<Course>();
        public Student(string StudentName)
        {
            this.StudentName = StudentName;
        }
        public void Enroll(Course course)
        {
            courses.Add(course);
            course.Students.Add(this);
        }
        public void showCourses()
        {
            Console.WriteLine("Courses enrolled by " + StudentName + ":");
            foreach (Course c in courses)
            {
                Console.WriteLine(c.CourseName);
            }
        }
    }
    internal class Course
    {
        public string CourseName;
        public List<Student> Students = new List<Student>();
        public Course(string CourseName)
        {
            this.CourseName = CourseName;
        }
        public void showStudents()
        {
            Console.WriteLine("Students enrolled in " + CourseName + ":");
            foreach (Student s in Students){
                Console.WriteLine(s.StudentName);
            }
        }
    }
}
