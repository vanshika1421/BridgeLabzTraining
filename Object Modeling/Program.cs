using System;
namespace Object_Modeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //School school = new School("Greenwood High");
            //Student student1 = new Student("Alice");
            //Student student2 = new Student("Bob");
            //Course course1 = new Course("Mathematics");
            //Course course2 = new Course("Science");
            //school.AddStudent(student1);
            //school.AddStudent(student2);
            //student1.Enroll(course1);
            //student1.Enroll(course2);
            //student2.Enroll(course1);
            //school.showStudents();
            //student1.showCourses();
            //student2.showCourses();
            //course1.showStudents();
            //course2.showStudents();
            University university = new University("Tech University");
            Faculty faculty1 = new Faculty("Dr. Smith");
            Faculty faculty2 = new Faculty("Dr. Johnson");
            
           
            university.AddFaculty(faculty1);
            university.AddFaculty(faculty2);
            university.addDepartment("Computer Science");
            university.ShowDepartments();
            university.ShowFaculty();
            university = null;
            Console.WriteLine("After deleting university");
            university.ShowFaculty();
           // university.ShowDepartments();
        }
    }
}