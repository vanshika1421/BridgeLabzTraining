using Keywords;
//using System.Runtime.Intrinsics.X86;

//Sample Program 1: Bank Account System
//Create a BankAccount class with the following features:
//static: 
//A static variable bankName shared across all accounts.
//A static method GetTotalAccounts() to display the total number of accounts.
//this: 
//Use this to resolve ambiguity in the constructor when initializing AccountHolderName and AccountNumber.
//readonly: 
//Use a readonly variable AccountNumber to ensure it cannot be changed once assigned.
//is operator: 
//Check if an account object is an instance of the BankAccount class before displaying its details.



using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    internal class BankAccount
    {
        public static string bankName = "State Bank of India";
        readonly int accountNumber;
        public static int count;
        string AccountHolder;
        public BankAccount( string AccountHolder ,int accountNumber)
        {
            this.AccountHolder = AccountHolder;
            this.accountNumber = accountNumber;
            count++;
        }
        public static int getTotalAccounts()
        {
            return count;
        }
        public void showDetails()
        {
            Console.WriteLine("Account Number is " + accountNumber);
            Console.WriteLine("Number of counts " + getTotalAccounts());

        }
    }
}
