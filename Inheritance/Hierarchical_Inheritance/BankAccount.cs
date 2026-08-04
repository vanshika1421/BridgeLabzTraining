//Sample Problem 1: Bank Account Types
//○ Description: Model a banking system with different account types using
//hierarchical inheritance. BankAccount is the superclass, with
//SavingsAccount, CheckingAccount, and FixedDepositAccount as
//subclasses.
//○ Tasks:
//■ Define a base class BankAccount with attributes like AccountNumber
//and Balance.
//■ Define subclasses SavingsAccount, CheckingAccount, and
//FixedDepositAccount, each with unique attributes like
//interestRate for SavingsAccount and WithdrawalLimit for
//CheckingAccount.
//■ Implement a method DisplayAccountType() in each subclass to
//specify the account type.
//○ Goal: Explore hierarchical inheritance, demonstrating how each subclass can
//have unique attributes while inheriting from a shared superclass
using System;

namespace BankAccountHierarchy
{
    // Base Class
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("Account Type : Bank Account");
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Balance        : ₹{Balance}");
        }
    }

    // Savings Account
    internal class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Account Type : Savings Account");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Interest Rate : {InterestRate}%");
        }
    }

    // Checking Account
    internal class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit { get; set; }

        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Account Type : Checking Account");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Withdrawal Limit : ₹{WithdrawalLimit}");
        }
    }

    // Fixed Deposit Account
    internal class FixedDepositAccount : BankAccount
    {
        public int DepositPeriod { get; set; }

        public FixedDepositAccount(int accountNumber, double balance, int depositPeriod)
            : base(accountNumber, balance)
        {
            DepositPeriod = depositPeriod;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Account Type : Fixed Deposit Account");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Deposit Period : {DepositPeriod} Months");
        }
    }

   
        }
  