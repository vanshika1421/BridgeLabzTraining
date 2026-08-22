//Practice Problems on Reflection in C#
//🔹 Basic Level
//Get Class Information: Write a program to accept a class name as input and display its methods, fields, and constructors using Reflection.
//Access Private Field: Create a class Person with a private field age.Use Reflection to modify and retrieve its value.
//Invoke Private Method: Define a class Calculator with a private method Multiply(int a, int b). Use Reflection to invoke this method and display the result. 
//Dynamically Create Objects: Write a program to create an instance of a Student class dynamically using Reflection without using the new keyword.


using Reflection.Basic_Questions;
using System.Reflection;

public class Program
{
    public static void Main(String[] args)
    {
        Type t = typeof(DisplayClassInfo);
        Console.WriteLine(t.Name);
       foreach (MethodInfo m  in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }


    }
}