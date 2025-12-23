public class Book : LibraryItem, IReversible, INotifiable
{
    public override void DisplayItem()
    {
        // Console.WriteLine($"Book Details");
        Console.WriteLine($"Title : {Title}");
        Console.WriteLine($"Author : {Author}");
        Console.WriteLine($"ItemId : {ItemId}");   
    }

    void IReversible.ReserveItem()
    {
        Console.WriteLine("Book Reserved Successfully");

    }

    void INotifiable.AcceptNotification(string message)
    {
        Console.WriteLine($"Notification Sent: {message}");
    }

    public override double CalculateLateFee(int daysLate)
    {
        return daysLate * 1.0;
    }
}

public class Magazine : LibraryItem
{
    public override void DisplayItem()
    {
        // Console.WriteLine("Magazine Details");
        Console.WriteLine($"Title : {Title}");
        Console.WriteLine($"Author : {Author}");
        Console.WriteLine($"ItemId : {ItemId}");
    }

    public override double CalculateLateFee(int daysLate)
    {
        return daysLate * 0.5;
    }
}

namespace LibrarySystem.Users
{
    public class Member
    {
        
    }

    
}