using System;
using System.Collections.Generic;
public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();
    public static void Main()
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            BikeUtility bike = new BikeUtility();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine();
                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine();
                    Console.Write("Enter the price per day: ");
                    int pricePerDay = int.Parse(Console.ReadLine());

                    bike.AddBikeDetails(model, brand, pricePerDay);
                    Console.WriteLine("\nBike details added successfully \n");
                    break;

                case 2:
                    var result = bike.GroupBikesByBrand();
                    foreach(var group in result)
                    {
                        foreach(Bike b in group.Value)
                        {
                            Console.WriteLine($"{group.Key} {b.Model}");
                        }
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    check = false;
                    break;
            }
        }
    }
}