using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

class Demo
{
    [ImportantMethod]
    public void Login()
    {
        Console.WriteLine("Login");
    }

    [ImportantMethod("LOW")]
    public void Logout()
    {
        Console.WriteLine("Logout");
    }

    public void NormalMethod()
    {
        Console.WriteLine("Normal");
    }
}