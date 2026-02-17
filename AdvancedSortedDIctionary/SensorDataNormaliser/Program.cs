using System;
using System.Collections.Generic;
using System.Globalization;
public interface IValueParser
{
    bool TryParseValue(string input, out float value);
}
public interface INumberRounder
{
    float RoundValue(float value);
}

public class SensorDataNormalizer : IValueParser, INumberRounder
{
    public bool TryParseValue(string input, out float value)
    {
        value = 0;

        if (string.IsNullOrWhiteSpace(input))
            return false;

        string trimmed = input.Trim();

        if (trimmed.Equals("null", StringComparison.OrdinalIgnoreCase))
            return false;

        if (trimmed.Equals("NaN", StringComparison.OrdinalIgnoreCase))
            return false;

        return float.TryParse(trimmed,out value);
    }

    public float RoundValue(float value)
    {
        return (float)Math.Round(value, 2);
    }

    public float[] Normalize(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return null;

        string[] parts = input.Split(',');
        List<float> validValues = new List<float>();

        foreach (string part in parts)
        {
            if (TryParseValue(part, out float number))
            {
                float rounded = RoundValue(number);
                validValues.Add(rounded);
            }
        }

        if (validValues.Count == 0)
            return null;

        return validValues.ToArray();
    }
}
class Program
{
    static void Main()
    {
        string input = " 24.5678, 18.9, null, , 31.0049, error, 29, 17.999, NaN ";

        SensorDataNormalizer normalizer = new SensorDataNormalizer();

        float[] result = normalizer.Normalize(input);

        if (result == null)
        {
            Console.WriteLine("No valid data.");
            return;
        }

        Console.Write("{ ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i].ToString("F2"));
            if (i < result.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine(" }");
    }
}
