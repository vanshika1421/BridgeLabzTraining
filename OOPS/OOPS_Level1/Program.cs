using System;
namespace OOPS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //EmployeeDetails emp = new EmployeeDetails("Vanshika", 101, 50000);

            //emp.displayDetails();
            //areaOfCircle obj = new areaOfCircle(10);
            //obj.DisplayDetails();
            BookDetails bd = new BookDetails("Fly high" ,"abc" , 897.852369 );

            bd.displayDetails();
        }
    }
}