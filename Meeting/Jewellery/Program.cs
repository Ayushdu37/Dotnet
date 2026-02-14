using System;
using System.Collections.Generic;

public class Jewellery
{
    public string Id { get; set; }
    public string Type { get; set; }
    public string Material { get; set; }
    public int Price { get; set; }
}

public class JewelleryUtility
{
    public Dictionary<string, string> GetJewelleryDetails(string id)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();

        foreach (var item in Program.jewelleryDetails)
        {
            if (item.Value.Id == id)
            {
                string value = item.Value.Type + "_" + item.Value.Material;
                result.Add(item.Value.Id, value);
                break;
            }
        }

        return result;
    }

    public Dictionary<string, Jewellery> UpdateJewelleryPrice(string id, int price)
    {
        Dictionary<string, Jewellery> result = new Dictionary<string, Jewellery>();

        foreach (var item in Program.jewelleryDetails)
        {
            if (item.Value.Id == id)
            {
                item.Value.Price = price;
                result.Add(item.Value.Id, item.Value);
                break;
            }
        }

        return result;
    }
}

public class Program
{
    public static Dictionary<int, Jewellery> jewelleryDetails = new Dictionary<int, Jewellery>();

    public static void Main(string[] args)
    {
        jewelleryDetails.Add(1, new Jewellery { Id = "JW01", Type = "Bracelet", Material = "Silver", Price = 5000 });
        jewelleryDetails.Add(2, new Jewellery { Id = "JW02", Type = "Ring", Material = "Gold", Price = 8000 });
        jewelleryDetails.Add(3, new Jewellery { Id = "JW03", Type = "Necklace", Material = "Gold", Price = 12000 });

        JewelleryUtility utility = new JewelleryUtility();

        while (true)
        {
            Console.WriteLine("1. Get Jewellery Details");
            Console.WriteLine("2. Update Price");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the jewellery id");
                string id = Console.ReadLine();

                var result = utility.GetJewelleryDetails(id);

                if (result.Count == 0)
                {
                    Console.WriteLine("Jewellery id not found");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Key + "   " + item.Value);
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the jewellery id");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the price to be updated");
                int price = Convert.ToInt32(Console.ReadLine());

                var result = utility.UpdateJewelleryPrice(id, price);

                if (result.Count == 0)
                {
                    Console.WriteLine("Jewellery id not found");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine("Id : " + item.Value.Id + ",    Type : " + item.Value.Type + ",    Material : " + item.Value.Material + ",    Price : " + item.Value.Price);
                    }
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you");
                break;
            }
        }
    }
}
