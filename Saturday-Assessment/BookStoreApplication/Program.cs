using System;

namespace BookStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // 1. Read initial input
            // Format: BookID Title Price Stock
            

            Book book = new Book();
            string input = Console.ReadLine();
            string[] parts = input.Split(" ");
            book.Id = parts[0];
            book.Title = parts[1];
            book.Price = Int32.Parse(parts[2]);
            book.Stock = Int32.Parse(parts[3]);

            BookUtility utility = new BookUtility(book);
            bool check = true;

            while (check)
            {
                // TODO:
                // Display menu:
                // 1 -> Display book details
                // 2 -> Update book price
                // 3 -> Update book stock
                // 4 -> Exit
                Console.WriteLine("1 -> Display book details");
                Console.WriteLine("2 -> Update book price");
                Console.WriteLine("3 -> Update stock price");
                Console.WriteLine("4 -> Exit");

                int choice = 0; // TODO: Read user choice
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.GetBookDetails();
                        break;

                    case 2:
                        // TODO:
                        // Read new price
                        // Call UpdateBookPrice()
                        int newPrice = Int32.Parse(Console.ReadLine());
                        utility.UpdateBookPrice(newPrice);
                        utility.GetBookDetails();
                        break;

                    case 3:
                        // TODO:
                        // Read new stock
                        // Call UpdateBookStock()
                        int stock = Int32.Parse(Console.ReadLine());
                        utility.UpdateBookStock(stock);
                        utility.GetBookDetails();
                        break;

                    case 4:
                        Console.WriteLine("Thank You");
                        return;
                        break;

                    default:
                        // TODO: Handle invalid choice
                        if(choice > 5)
                        {
                            check = false;
                        }
                        break;
                }
            }
        }
    }
}
