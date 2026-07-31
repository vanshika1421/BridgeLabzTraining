using System;

namespace Instance_vs._Class_Variables_and_Methods
{
    internal class OnlineCourseManagement
    {
        // Class Variable
        public static string instituteName = "Chitkara University";

        // Instance Variables
        string courseName;
        int duration;
        double fee;

        // Constructor
        public OnlineCourseManagement(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        // Static Method
        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
        }

        // Instance Method
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Course Name    : {courseName}");
            Console.WriteLine($"Duration       : {duration} months");
            Console.WriteLine($"Fee            : {fee}");
            Console.WriteLine($"Institute Name : {instituteName}");
        }
    }
}