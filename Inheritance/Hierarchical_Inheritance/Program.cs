using BankAccountHierarchy;
using SchoolSystem;

internal class Program
{
    static void Main(string[] args)
    {
        //    BankAccount[] accounts =
        //    {
        //            new SavingsAccount(101, 50000, 6.5),
        //            new CheckingAccount(102, 25000, 10000),
        //            new FixedDepositAccount(103, 100000, 24)
        //        };

        //    foreach (BankAccount account in accounts)
        //    {
        //        account.DisplayAccountType();
        //        account.DisplayDetails();
        //        Console.WriteLine("-----------------------------");
        //    }
        //}
        Person[] people =
            {
                new Teacher("Rahul", 35, "Mathematics"),
                new Student("Priya", 20, "B.Tech 2nd Year"),
                new Staff("Aman", 40, "Administration")
            };

        foreach (Person person in people)
        {
            person.DisplayRole();
            person.DisplayDetails();
            Console.WriteLine("----------------------------");
        }
    }

}