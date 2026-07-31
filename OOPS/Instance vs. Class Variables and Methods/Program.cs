using System;
using System.ComponentModel;
namespace Instance_vs._Class_Variables_and_Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Product p = new Product("Baby soap" , 100);
            //Product p2 = new Product("Lostion", 145);
            //Product p3 = new Product("Face Wash", 275); 
            //p.DisplayDetails();
            OnlineCourseManagement ocm = new OnlineCourseManagement("c#", 3, 2500.65);
            ocm.DisplayCourseDetails();

        }
    }
}