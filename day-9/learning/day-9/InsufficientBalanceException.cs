using System;
using System.IO;

class InsufficentBalanceException : Exception
{
    public InsufficentBalanceException(string message) : base(message)
    {

    }
}

class BankAccount
{
    public decimal Balance { get; private set; } = 5000;
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be greater than zero.");
        }
        if (amount > Balance)
        {
            throw new InsufficentBalanceException("Insufficent balance for withdraw.");
        }
        Balance -= amount;
    }


}