using System;
namespace Student;
public class Program
{
    public static void Main(String[] args)
    {
        Student s = new Student();
        s.AddElement(1 ,"Name1" ,'A' , 1);
        s.AddElement(2, "Name2", 'B', 2);
        s.AddElement(4, "Name3", 'c', 3);
        s.AddElement(5, "Name4", 'D', 4);
        s.AddAtLast(6, "NameLast1", 'E', 5);
        s.AddAtLast(7, "Nameast2", 'E', 6);
        s.AddAtSpecificPosition(9, "posAdd", 'p', 10, 3);
        s.findByRollNumber(5);
        s.RemoveByRollNumber(5);
        s.updateGrade(6, 'A');
        s.display();
    }
}