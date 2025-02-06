// Demonstration of Encapsulation
using System;

public class BankAccount
{
    private decimal balance;

    // Constructor
    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    // Deposit Method
    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    // Withdraw Method
    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    // Check the Balance of Account
    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create new Bank Account
        BankAccount myAccount = new BankAccount(1000);

        myAccount.Deposit(10500);
        Console.WriteLine("Balance: " + myAccount.GetBalance());

        myAccount.Withdraw(2000);
        Console.WriteLine("Balance: " + myAccount.GetBalance());
    }
}
