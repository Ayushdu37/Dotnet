using System;

public class Program
{
    public static string ConvertTime(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        return minutes + ":" + seconds.ToString("D2");
    }
    public static void Main()
    {
        int totalSeconds = int.Parse(Console.ReadLine());
        string result = ConvertTime(totalSeconds);
        Console.WriteLine(result);
    }
}