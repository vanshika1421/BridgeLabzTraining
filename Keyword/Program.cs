using System;
namespace Keywords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BankAccount bank = new BankAccount("Vanshika" , 98741365);
            //bank.showDetails();
            if (bank is BankAccount)
            {
                bank.showDetails();
            }

        }
    }
}