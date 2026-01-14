using System;
using System.Threading.Tasks;
using System.IO;

public class Program
{
    public static async Task Main()
    {
        // Thread worker = new Thread(DoWork);
        // worker.Start();
        // Console.WriteLine("Main thread continues...");

        // Parallel.For(0, 5, i=>{
        //     Thread.Sleep(2000);
        //     Console.WriteLine($"Processing item {i}");
        // });

        // int[] numbers = new int[10];
        // for(int i=0; i< numbers.Length; i++)
        // {
        //     numbers[i] = i + 1;
        // }
        // int sum = 0;
        // Parallel.For(0, numbers.Length, i =>
        // {
        //     sum += numbers[i];
        //     // Thread.Sleep(2000);
        // });
        // Console.WriteLine("Sum: " + sum);
        // Parallel.For(0, numbers.Length, () => 0,
        // (i, loopState, localSum) =>
        // {
        //     return localSum + numbers[i];
        // },
        // localSum =>
        // {
        //     Interlocked.Add(ref sum, localSum);
        // });
        // Console.WriteLine(await GetDataAsync());

        Console.WriteLine("Start reading file...");
        string content = await File.ReadAllTextAsync("data.txt");
        Console.WriteLine("File content: ");
        Console.WriteLine(content);
        Console.WriteLine("End of program");

    }
    // static async Task Main()
    // {
        
    // }
    static async Task<int> GetDataAsync()
    {
        await Task.Delay(1000);
        return 42;
    }
    static void DoWork()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Worker Thread: " + i);
            Thread.Sleep(5000);
        }
    }
}