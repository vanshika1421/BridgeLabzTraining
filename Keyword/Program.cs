using Keyword;
using System;
namespace Keywords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //BankAccount bank = new BankAccount("Vanshika" , 98741365);
            ////bank.showDetails();
            //if (bank is BankAccount)
            //{
            //    bank.showDetails();
            //}
            //object obj = new Book("The Alchemist", "Paulo Coelho", "ISBN101");

            //Book.DisplayLibraryName();

            //Console.WriteLine();

            //if (obj is Book)
            //{
            //    Console.WriteLine("Object is an instance of Book.\n");

            //    Book book = (Book)obj;
            //    book.DisplayBookDetails();
            //}
            //object emp1 = new Employee(101, "Vanshika", "Software Engineer");
            //object emp2 = new Employee(102, "Raghav", "HR Manager");

            //// Static Method
            //Employee.DisplayTotalEmployees();

            //Console.WriteLine();

            //// Using is Operator
            //if (emp1 is Employee)
            //{
            //    Employee e = (Employee)emp1;

            //    Console.WriteLine("emp1 is an Employee object.\n");
            //    e.DisplayEmployeeDetails();
            //}

            //Console.WriteLine();

            //if (emp2 is Employee)
            //{
            //    Employee e = (Employee)emp2;

            //    Console.WriteLine("emp2 is an Employee object.\n");
            //    e.DisplayEmployeeDetails();
            //}

            object obj1 = new Product(101, "Laptop", 60000, 2);
            object obj2 = new Product(102, "Mouse", 800, 3);

            // Update Discount
            Product.UpdateDiscount(15);

            // Using is operator
            if (obj1 is Product)
            {
                Product p = (Product)obj1;

                Console.WriteLine("Object is a Product.\n");
                p.DisplayProductDetails();
            }

            Console.WriteLine();

            if (obj2 is Product)
            {
                Product p = (Product)obj2;

                Console.WriteLine("Object is a Product.\n");
                p.DisplayProductDetails();
            }
        }
    }
}