class Program
{
    public static void Main()
    {
        Account user = new Account();

        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("Enter the choice");

        if(!int.TryParse(Console.ReadLine(), out int choice)) return;

        Console.WriteLine("Enter the account number");
        user.AcountNumber = Console.ReadLine();

        Console.WriteLine("Enter the balance");
        user.Balance = decimal.Parse(Console.ReadLine());

        if(choice == 1)
        {
            Console.WriteLine("Enter the amount to be deposit");
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal currentBalance = user.Deposit(amount);
            Console.WriteLine($"Balance amount: {currentBalance}");
        }
        else if(choice == 2)
        {
            Console.WriteLine("Enter the amount to be withdraw");
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal currentBalance = user.Withdraw(amount);
            Console.WriteLine($"Balance amount: {currentBalance}");
        }
    }
}