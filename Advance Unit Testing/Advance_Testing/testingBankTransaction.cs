
//Advanced C# Unit Testing Practice Problems
//1.Testing Banking Transactions
//Problem:
//Create a BankAccount class with :
//Deposit(double amount): Adds money to the balance.
//Withdraw(double amount): Reduces balance.
//GetBalance(): Returns the current balance.
//✅ Write unit tests to check correct balance updates.
using System;
using Advance_Unit_Testing;
namespace Advance_Testing
{
    public class Tests
    {
        private BankAccount bank;
        [SetUp]
        public void Setup()
        {
            bank = new BankAccount(5000);
        }

        [Test]
        public void Testing_Depoait_Money_Function()
        {
            //bank.BankAccount(500);
           // double b = 1000;
            bank.DepositMoney(1000);
           double ans = bank.getBalance();

            int res = 6000;
            Assert.That(res, Is.EqualTo(ans));
            bank.withdrawMoney(1000);
            int result = 5000;
            Assert.That(result, Is.EqualTo(result));
            
        }
    }
}