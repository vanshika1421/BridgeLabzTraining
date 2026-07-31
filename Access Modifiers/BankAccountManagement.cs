//Problem 3: Bank Account Management
//Create a BankAccount class with :
//accountNumber(public)
//accountHolder(protected)
//balance(private)
//Implement methods to:
//Access and modify balance using public methods.
//Create a subclass SavingsAccount to demonstrate access to accountNumber and accountHolder.


using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    internal class BankAccountManagement
    {
        protected string accountHolder;
        private int balance;
        public int accountNumber;
        public BankAccountManagement(int balance , int accountnumber , string accountHolder)
        {
            this.balance = balance;
            this.accountNumber = accountnumber;
            this.accountHolder = accountHolder;
        }
        public int getBalance() { return balance; }
        public void setBalance(int balance)
        {
            this.balance = balance;
        }


    }
    internal class SavingAccount : BankAccountManagement { 
    
    public SavingAccount(int balance, int accountnumber, string accountHolder) : base( balance,  accountnumber,  accountHolder)
        {

        }
        public void Display()
        {
            Console.WriteLine("AccountNumber is "+ accountNumber);
            Console.WriteLine("AccountHolder is " + accountHolder);
            Console.WriteLine("Balance is "+ getBalance());

        }
    }
}
