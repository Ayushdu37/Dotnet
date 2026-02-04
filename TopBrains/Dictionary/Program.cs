using System;

public class Program
{
    public static int TotalSalary(Dictionary<int, int> employeeSalaries, List<int> ids)
    {
        int totalSalary = 0;

        foreach(int id in ids)
        {
            if (employeeSalaries.ContainsKey(id))
            {
                totalSalary += employeeSalaries[id];
            }
        }
        return totalSalary;
    }
    public static void Main()
    {
        Dictionary<int, int> salaries = new Dictionary<int, int>()
        {
            {1, 20000},
            {4, 40000},
            {5, 15000}
        };

        List<int> ids = new List<int>(){1,4,5};

        int result = TotalSalary(salaries, ids);
        Console.WriteLine(result);
    }
}