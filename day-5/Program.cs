// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // Accessing via interface references
// IDisposable resource = new ResourceHandler();
// resource.Dispose();  // Works

// INotifier notifier = new ResourceHandler();
// notifier.Log();     // Works

// ResourceHandler obj = new ResourceHandler();
// obj.Dispose();      // ERROR: not accessible directly
// obj.Log();          // ERROR: not accessible directly



Book book = new Book();
book.Title = "1984";
book.Author = "George Orwell";
book.ItemId = 101;


Magazine magazine = new Magazine();
magazine.Title = "1984";
magazine.Author = "George Orwell";
magazine.ItemId = 101;

Console.WriteLine("Item Type: Book");
book.DisplayItem();
Console.WriteLine("Late Fee for 3 days : " + book.CalculateLateFee(3));

Console.WriteLine("\n");

Console.WriteLine("Item Type: Magazine");
magazine.DisplayItem();
Console.WriteLine("Late Fee for 3 days : " + magazine.CalculateLateFee(3));

// book.ReserveItem();
// book.AcceptNotification("Your book is ready for pick up.");

IReversible reversible = book;
reversible.ReserveItem();

INotifiable notifiable = book;
notifiable.AcceptNotification("Notification: Please return the book on time.");
Console.WriteLine("\n");

Items items = new Items();
items.DisplayItemDetails();


