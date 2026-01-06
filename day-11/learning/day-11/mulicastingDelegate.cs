using System;

// Multicasting Delegate
delegate void OrderDelegate(string orderId);

public class NotificationService
{
    public void SendEmail(string id)
    {
        Console.WriteLine($"Email sent for Order {id}");
    }
    public void SendSMS(string id)
    {
        Console.WriteLine($"SMS sent for Order {id}");
    }
}