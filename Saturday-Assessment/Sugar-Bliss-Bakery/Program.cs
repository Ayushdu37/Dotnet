using System.Diagnostics;
public class Program
{
    public static Chocolate CalculateDiscountedPrice(Chocolate chocolate)
    {
        chocolate.TotalPrice = chocolate.Quantity * chocolate.PricePerUnit;
        double DiscountedPercentage = 0;
        if (chocolate.Flavour == "Dark")
            DiscountedPercentage = 18;
        else if (chocolate.Flavour == "Milk")
            DiscountedPercentage = 12;
        else if (chocolate.Flavour == "White")
            DiscountedPercentage = 6;

        chocolate.DiscountedPrice = chocolate.TotalPrice - (chocolate.TotalPrice * DiscountedPercentage / 100);

        return chocolate;
    }
    public static void Main()
    {
        Trace.WriteLine("Application execution started");
        Chocolate chocolate = new Chocolate();

        Console.WriteLine("Enter the Flavour");
        chocolate.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the Quantity");
        chocolate.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Price Per Unit");
        chocolate.PricePerUnit = int.Parse(Console.ReadLine());

        if (!chocolate.ValidateChocolateFlavour())
        {
            Console.WriteLine("Invalid Flavour");
        }
        else
        {
            chocolate = CalculateDiscountedPrice(chocolate);

            Console.WriteLine("Flavour : " + chocolate.Flavour);
            Console.WriteLine("Quantity : " + chocolate.Quantity);
            Console.WriteLine("Price Per Unit : " + chocolate.PricePerUnit);
            Console.WriteLine("Total Price : " + chocolate.TotalPrice);
            Console.WriteLine("Discounted Price : " + chocolate.DiscountedPrice);
        }




    }
}