//Advanced C# Unit Testing Practice Problems
//1.Testing Banking Transactions
//Problem:
//Create a BankAccount class with :
//Deposit(double amount): Adds money to the balance.
//Withdraw(double amount): Reduces balance.
//GetBalance(): Returns the current balance.
//✅ Write unit tests to check correct balance updates.
//✅ Ensure withdrawals fail if funds are insufficient.
namespace Advance_Unit_Testing
{
    public class BankAccount
    {
        public double balance { get; set; }
        public BankAccount(double balance)
        {
            this.balance = balance;
        }
       
        public void DepositMoney(double amount)
        {
            balance += amount;
        }

        public void withdrawMoney(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public double getBalance() { return balance; }
    }
}
