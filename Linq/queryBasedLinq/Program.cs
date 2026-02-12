using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int[] numbers = {1,2,3,4,5,6};

        var evenNumbers = 
        from n in numbers
        where n % 2 == 0
        select n;

        Console.WriteLine("Query Syntax Output");
        foreach(var n in evenNumbers)
        {
            Console.WriteLine(n);
        }

        evenNumbers = numbers.Where(n => n % 2 == 0);
        foreach(var n in evenNumbers)
        {
            Console.WriteLine(n);
        }

        int maxNumber = numbers.Max();
        Console.WriteLine(maxNumber);

        List<int> num = new List<int>{10,25,30,45,60};
        var filtered = num.Where(n => n > 20);

        var squares = num.Select(n => n*n);
        
        var take = num.Take(3);
        Console.WriteLine(take);
    }
}