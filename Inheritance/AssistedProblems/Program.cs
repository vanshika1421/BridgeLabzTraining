using EmployeeManagement;
using LibraryManagement;
using System;
using VehicleTransportSystem;
namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal myDog = new Dog { Name = "Buddy", Age = 3 };
            //Animal myCat = new Cat { Name = "Whiskers", Age = 2 };
            //Animal myBird = new Bird { Name = "Tweety", Age = 1 };
            //myDog.MakeSound(); // Output: Dog barks
            //myCat.MakeSound(); // Output: Cat meows
            //myBird.MakeSound(); // Output: Bird chirps
            //Console.ReadLine();
            //      Employee[] employees =
            //{
            //          new Manager("Rahul", 101, 80000, 10),
            //          new Developer("Priya", 102, 60000, "C#"),
            //          new Intern("Aman", 103, 15000, "6 Months")
            //      };

            //      foreach (Employee employee in employees)
            //      {
            //          employee.DisplayDetails();
            //          Console.WriteLine("----------------------------");
            //      }
            //Vehicle[] vehicles =
            //      {
            //    new Car(180, "Petrol", 5),
            //    new Truck(120, "Diesel", 10000),
            //    new Motorcycle(150, "Petrol", false)
            //};

            //foreach (Vehicle vehicle in vehicles)
            //{
            //    vehicle.DisplayInfo();
            //    Console.WriteLine("--------------------------");
            //}

            Book book = new Author(
                "The Alchemist",
                1988,
                "Paulo Coelho",
                "Brazilian novelist"
            );

            book.DisplayInfo();
        }
    }
}
