using System;
public partial class Program
{
    // Delegates
    delegate void PaymentDelegate(decimal amount);
    delegate void ErrorDelegate(string msg);

    class PaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Payment of " + amount + " processed successfully.");
        }
    }
    public static void Main()
    {
        PaymentService service = new PaymentService();

        PaymentDelegate payment = service.ProcessPayment; // delegate assignment

        decimal amount = 5000;
        if (amount.isValidPayment())
        {
            payment(5000);
        }
        else
        {
            Console.WriteLine("Invalid amount.");
        }

        NotificationService service1 = new NotificationService();
        OrderDelegate notify = null;

        notify += service1.SendEmail;
        notify += service1.SendSMS;

        notify("ORD001");

        // Action Delegate
        Action<string> logActivity = message => Console.WriteLine($"Log Entry: {message}");

        logActivity("User logged in at 10:30 AM");

        // Func Delegate
        Func<decimal, decimal, decimal> calculateDiscount = (price, discount) => price - (price * discount) / 100;
        Console.WriteLine(calculateDiscount(1000,10));

        // Predicate Delegate
        Predicate<int> isEligible = age => age >= 18;
        Console.WriteLine($"Its {isEligible(20)}");

        // Anonymous Delegate
        ErrorDelegate errorHandler = delegate (string message)
        {
            Console.WriteLine($"Error : {message}");
        };

        errorHandler("File not Found");

     // Event Delegate
        ButtonDemo();

     // Comparison Generic Delegate    
        Comparison<int> sortDescending = (a,b)=>b.CompareTo(a);
    }
}

static class PaymentExtensions
    {
        public static bool isValidPayment(this decimal amount)
        {
            return amount > 0 && amount < 1000000;
        }
    }