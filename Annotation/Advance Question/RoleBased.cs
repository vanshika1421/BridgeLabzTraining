using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role;

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class AdminPanel
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User Deleted Successfully!");
    }
}