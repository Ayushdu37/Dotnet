public class Account
{
    public string AcountNumber{get; set;}
    public decimal Balance{get; set;}

    public decimal Deposit(decimal amount)
    {
        try
        {
            if(amount > 0)
            {
                Balance += amount;
            }
            else
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
        }catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        return Balance;
    }

    public decimal Withdraw(decimal amount)
    {
        try
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            else if(amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            else
            {
                Balance -= amount;
            }
        }catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        return Balance;
    }
}