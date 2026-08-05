//4.Banking System
//Description: Create a banking system with different account types:
//Define an abstract class BankAccount with fields like accountNumber, holderName, and balance.
//Add methods like Deposit(double amount), Withdraw(double amount), and an abstract method CalculateInterest().
//Implement subclasses SavingsAccount and CurrentAccount with unique interest calculations.
//Create an interface ILoanable with methods ApplyForLoan() and CalculateLoanEligibility().
//Use encapsulation to secure account details and restrict unauthorized access.
//Demonstrate polymorphism by processing different account types and calculating interest dynamically


using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    abstract internal class BankAccont
    {
        public  int accountNumber { get; private set; }
        public string holderName { get;  private set; }
        public double balance { get; private set; }
        public BankAccont(int accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        public abstract double CalculateInterest();
    }
    internal class SavingAccount : BankAccont , ILoanable
    {
        private double interestRate = 0.04; // 4% interest rate
        public SavingAccount(int accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance)
        {
        }
        public void ApplyForLoan(double loanAmount)
        {
            Console.WriteLine("Loan application submitted for amount: " + loanAmount);
        }
        public bool CalculateLoanEligibility( double loanAmount)
        {
            if (loanAmount <= balance * 2) // Example eligibility criteria
            {
                Console.WriteLine("Loan approved ");
                return true;
            }
            else
            {
                Console.WriteLine("Loan denied ");
                return false;
            }
        }
        public override double CalculateInterest()
        {
            return balance * interestRate;
        }

    }
internal class CurrentAccount : BankAccont , ILoanable
    {private double interestRate = 0.02; // 2% interest rate
        public CurrentAccount(int accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance)
        {
        }
        public override double CalculateInterest()
        {
            return balance * interestRate;
        }  
        public void ApplyForLoan(double loanAmount)
        {
            Console.WriteLine("Loan application submitted for amount: " + loanAmount);
        }
        public bool CalculateLoanEligibility( double loanAmount)
        {
            if (loanAmount <= balance * 2) // Example eligibility criteria
            {
                Console.WriteLine("Loan approved ");
                return true;
            }
            Console.WriteLine("Loan denied ");
            return false;
        }
    }
    interface ILoanable
    {
        void ApplyForLoan(double loanAmount);
        bool CalculateLoanEligibility( double loanAmount );
    }
}

