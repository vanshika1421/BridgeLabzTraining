using System;
namespace Access_Modifiers
{
    internal class Program
    {
        public static void Main(string[] args)
        //{
        //    PostgraduateStudents um = new PostgraduateStudents("Vanshika",2476, 9.3f);
        //    um.displayDetails();
        //    um.setCgpa(9.5f);
        //    Console.WriteLine("After cgpa updation the new cgpa is : " +um.getCgpa());
        { 
            //EBook b = new EBook(123456789 , "vanshika" , "chhabra");
            //b.display();
            //b.setAuthor("Kavya");
            //Console.WriteLine("After author updation  " + b.getAuthor());
         SavingAccount sv = new SavingAccount(80000 ,9897145 , "Rahgav");
            sv.Display();
            sv.setBalance(5800);
            Console.WriteLine("After updation the balance is : " + sv.getBalance());
        }
    }
}