//Exercise 1: Use Method Overriding Correctly
//Problem Statement: Create a parent class Animal with a method MakeSound(). Then, create a Dog class that overrides this method using override.
//Steps to Follow:
//Define a MakeSound() method in the Animal class.
//Override it in the Dog class with override.
//Instantiate Dog and call MakeSound().
//using Annotation;

//class Program
//{
//    static void Main()
//    {
//        Dog d = new Dog();
//        d.MakeSound();
//    }
//}
using System.Diagnostics;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

//class Program
//{
//    static void Main()
//    {
//        string currentRole = "USER";   // Change to "ADMIN"

//        AdminPanel panel = new AdminPanel();

//        MethodInfo method = typeof(AdminPanel).GetMethod("DeleteUser");

//        RoleAllowedAttribute role =
//            (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

//        if (role != null && role.Role == currentRole)
//        {
//            method.Invoke(panel, null);
//        }
//        else
//        {
//            Console.WriteLine("Access Denied!");
//        }
//    }
//}
class Program
{
    static void Main()
    {
        Type t = typeof(Demo);

        foreach (MethodInfo method in t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            ImportantMethodAttribute attr =
                (ImportantMethodAttribute)Attribute.GetCustomAttribute(method, typeof(ImportantMethodAttribute));

            if (attr != null)
            {
                Console.WriteLine($"Method: {method.Name}, Level: {attr.Level}");
            }
        }
    }
}

//class Program
//{
//    static void ExecuteWithTime(object obj, string methodName)
//    {
//        MethodInfo method = obj.GetType().GetMethod(methodName);

//        if (Attribute.IsDefined(method, typeof(LogExecutionTimeAttribute)))
//        {
//            Stopwatch sw = new Stopwatch();

//            sw.Start();
//            method.Invoke(obj, null);
//            sw.Stop();

//            Console.WriteLine("Time: " + sw.ElapsedMilliseconds + " ms");
//        }
//        else
//        {
//            method.Invoke(obj, null);
//        }
//    }

//    static void Main()
//    {
//        Test t = new Test();

//        ExecuteWithTime(t, "Method1");
//        ExecuteWithTime(t, "Method2");
//    }
//}