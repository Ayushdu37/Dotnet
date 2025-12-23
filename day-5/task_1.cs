public abstract class LibraryItem
{
    public string title;
    public string Title
    {
        get;
        set;
    }

    public string author;
    public string Author
    {
        get;
        set;
    }

    public int itemId;
    public int ItemId
    {
        get;
        set;
    }

    public abstract void DisplayItem();
    public abstract double CalculateLateFee(int daysLate);

}



