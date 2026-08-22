//10.Implementing a Bank Transaction System
//💡 Problem Statement:
//Develop a Bank Account System where:
//Withdraw(double amount) method:
//Throws InsufficientFundsException if withdrawal amount exceeds balance.
//Throws ArgumentException if the amount is negative.
//Handle exceptions in Main().
//Expected Behavior:
//If valid, print "Withdrawal successful, new balance: X".
//If balance is insufficient, throw and handle "Insufficient balance!".
//If the amount is negative, throw and handle "Invalid amount!".


using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    internal class BankTransaction
    {
        public void Withdraw(double Amount ,double balance)
        {
            

                if (Amount < 0)
                {
                    throw new ArgumentException("Invalid Amount");
                }
           

                              
                    if (Amount > balance)
                    {
                        throw new InsufficientFundsException("Insfficient Balance");
                    }
            Console.WriteLine("Updated valance is " + (balance-Amount));
               
        }

    }
}
