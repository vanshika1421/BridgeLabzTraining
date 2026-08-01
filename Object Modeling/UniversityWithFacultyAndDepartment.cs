//Problem 2: University with Faculties and Departments (Composition and Aggregation)
//Description: Create a University with multiple Faculty members and Department objects. Model it so that the University and its Departments are in a composition relationship (deleting a university deletes all departments), and the Faculty members are in an aggregation relationship (faculty can exist outside of any specific department).
//Tasks:
//Define a University class with Department and Faculty classes.
//Demonstrate how deleting a University also deletes its Departments.
//Show that Faculty members can exist independently of a Department.
//using System;


namespace Object_Modeling
{
    internal class University
    {
        public string UniversityName;
         List<Department> departments = new List<Department>();
         List<Faculty> faculties = new List<Faculty>();
        public University(string UniversityName)
        {
            this.UniversityName = UniversityName;
        }
        public  void addDepartment(String departmentName)
        {
            Department department = new Department(departmentName);
            departments.Add(department);
        }
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }
        public void ShowDepartments()
        {
            Console.WriteLine("Departments:");
            foreach (Department d in departments)
            {
                Console.WriteLine(d.DepartmentName);
            }
        }

        public void ShowFaculty()
        {
            Console.WriteLine("Faculty Members:");
            foreach (Faculty f in faculties)
            {
                Console.WriteLine(f.FacultyName);
            }
        }
    }
    internal class Faculty
    {
        public string FacultyName;
        public Faculty(string FacultyName)
        {
            this.FacultyName = FacultyName;
        }
    }
    internal class Department
    {
        public string DepartmentName;
        
        public Department(string DepartmentName)
        {
            this.DepartmentName = DepartmentName;
        }
    }
}
