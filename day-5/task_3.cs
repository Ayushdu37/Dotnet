class Items
{
    private Dictionary<int, LibraryItem> items = new Dictionary<int, LibraryItem>();

    public Items()
    {
        items.Add(1, new Book
        {
            Title = "Clean Code",
            Author = "Robert C. Martin",
            ItemId = 101
        });

        items.Add(2, new Magazine
        {
            Title = "Tech Monthly",
            Author = "Editorial Team",
            ItemId = 202
        });
    }

    public void DisplayItemDetails()
    {
        foreach(KeyValuePair<int, LibraryItem> item in items)
        {
            item.Value.DisplayItem();
            Console.WriteLine();
        }
    }
}



