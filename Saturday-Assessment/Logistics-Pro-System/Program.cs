public class Program
{
    public static void Main()
    {
        ShipmentDetails shipment = new ShipmentDetails();

        Console.Write("Input ID: ");
        shipment.ShipmentCode = Console.ReadLine();

        if (!shipment.ValidateShipmentCode())
        {
            Console.WriteLine("Invalid shipment code");
            return;
        }
        
        Console.Write("Mode: ");
        shipment.TransportMode = Console.ReadLine();

        Console.Write("Weight: ");
        shipment.Weight = Int32.Parse(Console.ReadLine());

        Console.Write("Storage: ");
        shipment.StorageDays = Int32.Parse(Console.ReadLine());

        double result = shipment.CalculateTotalCost();
		Console.WriteLine($"The total shipping cost is {result.ToString("F2")}");


    }
}