using System;

class BankAccount
{
    private int account_number;
    private double balance;

    private static string BankName = "Union Bank";

    public BankAccount(int AccNum, double initial_balance)
    {
        this.account_number = AccNum;
        this.balance = initial_balance;
    }

    public void Deposit(double amount)
    {
        if(amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount Deposited.");
        }
        else
        {
            Console.WriteLine("Invalid Amount.");
        }
    }

    public void Deposit(ref double amount)
    {
        if(amount > 0)
        {
            balance += amount;
            amount = 0;
            Console.WriteLine("Amount deposited using ref.");
        }
    }

    public bool Withdraw(double amount, out string message)
    {
        if(amount <= 0)
        {
            message = "Insufficient Balance.";
            return false;
        }
        balance -= amount;
        message = "Withdraw Successful.";
        return true;
    }

    public void Display()
    {
        Console.WriteLine($"Bank Name : {BankName}");
        Console.WriteLine($"Account No : {account_number}");
        Console.WriteLine($"Balance : ₹{balance}");
    }
}