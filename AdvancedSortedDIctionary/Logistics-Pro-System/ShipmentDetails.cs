using System;

public class ShipmentDetails : Shipment
{
	public bool ValidateShipmentCode()
	{
		if(ShipmentCode.Length != 7)
		{
			return false;
		}
		if (!ShipmentCode.StartsWith("GC#"))
		{
			return false;
		}
		string numericPart = ShipmentCode.Substring(3);
        foreach (char ch in numericPart)
        {
			if (!char.IsDigit(ch)) return false;
        }
		return true;
    }
	public double CalculateTotalCost()
	{
		double RatePerKg = 0;

		if(TransportMode == "Sea")
		{
			 RatePerKg = 15.00;
		}else if(TransportMode == "Air")
		{
			RatePerKg = 50.00;
		}else if(TransportMode == "Land")
		{
			RatePerKg = 25.00;
		}
		double TotalCost = (Weight * RatePerKg) + Math.Sqrt(StorageDays);
		return TotalCost;
	}
}
