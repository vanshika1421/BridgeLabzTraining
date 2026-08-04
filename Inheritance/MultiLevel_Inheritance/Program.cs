using EducationalCourseHierarchy;
using OnlineRetailOrderManagement;

internal class Program
{
    static void Main(string[] args)
    {
        //Order order = new Order(101, DateTime.Now);

        //ShippedOrder shippedOrder =
        //    new ShippedOrder(102, DateTime.Now, "TRK12345");

        //DeliveredOrder deliveredOrder =
        //    new DeliveredOrder(
        //        103,
        //        DateTime.Now,
        //        "TRK67890",
        //        DateTime.Now.AddDays(2));

        //Console.WriteLine(order.GetOrderStatus());

        //Console.WriteLine(shippedOrder.GetOrderStatus());

        //Console.WriteLine(deliveredOrder.GetOrderStatus());
        Course course = new Course(
              "C# Fundamentals",
              40);

        OnlineCourse onlineCourse = new OnlineCourse(
            "ASP.NET Core",
            60,
            "Udemy",
            true);

        PaidOnlineCourse paidCourse = new PaidOnlineCourse(
            "Advanced .NET",
            80,
            "Coursera",
            true,
            5000,
            20);

        course.DisplayDetails();

        Console.WriteLine("------------------------");

        onlineCourse.DisplayDetails();

        Console.WriteLine("------------------------");

        paidCourse.DisplayDetails();
    }
}