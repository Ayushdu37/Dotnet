class Parent
{
    public Parent(int x)
    {
        Console.WriteLine("Parent constructor: " + x);
    }
}

class Child : Parent
{
    public Child() : base(10)
    {
        Console.WriteLine("Child constructor");
    }
}

class Product
{
    public string Name;
    public int Price;

    public Product() { } // Default Constructor

    public Product(string name, int price) // Paramterized Constructor
    {
        Name = name;
        Price = price;
    }
}