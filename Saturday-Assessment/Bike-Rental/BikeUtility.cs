public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count + 1;
        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };

        Program.bikeDetails.Add(key, bike);
    }
    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes = new SortedDictionary<string, List<Bike>>();

        foreach(var entry in Program.bikeDetails)
        {
            Bike bike = entry.Value;
            string brand = bike.Brand;

            if (!groupedBikes.ContainsKey(brand))
            {
                groupedBikes[brand] = new List<Bike>();
            }

            groupedBikes[brand].Add(bike);
        }
        return groupedBikes;
    }
}