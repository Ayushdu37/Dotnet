using System;

public class ShipmetDetails : Shipment
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
	public double CalculateTotalCost(double RatePerKg)
	{

	}
}
