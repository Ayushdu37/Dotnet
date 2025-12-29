using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== ENTERPRISE DATA PROCESSING SYSTEM =====\n");

        //    TASK 1 – PRODUCT PRICE ANALYSIS

        Console.Write("Enter number of products: ");
        int productCount = int.Parse(Console.ReadLine());

        int[] prices = new int[productCount];
        int sum = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            while (true)
            {
                Console.Write($"Enter price for product {i}: ");
                int value = int.Parse(Console.ReadLine());
                if (value > 0)
                {
                    prices[i] = value;
                    sum += value;
                    break;
                }
                Console.WriteLine("Price must be positive.");
            }
        }

        double averagePrice = (double)sum / prices.Length;
        Array.Sort(prices);

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < averagePrice)
                prices[i] = 0;
        }

        int oldSize = prices.Length;
        Array.Resize(ref prices, oldSize + 5);

        for (int i = oldSize; i < prices.Length; i++)
            prices[i] = (int)averagePrice;

        Console.WriteLine("\nFinal Product Prices:");
        for (int i = 0; i < prices.Length; i++)
            Console.WriteLine($"Index {i}: {prices[i]}");

        //    TASK 2 – BRANCH SALES (2D ARRAY)

        Console.Write("\nEnter number of branches: ");
        int branches = int.Parse(Console.ReadLine());

        Console.Write("Enter number of months: ");
        int months = int.Parse(Console.ReadLine());

        int[,] sales = new int[branches, months];
        int highestSale = 0;

        for (int i = 0; i < branches; i++)
        {
            for (int j = 0; j < months; j++)
            {
                Console.Write($"Sales for Branch {i}, Month {j}: ");
                sales[i, j] = int.Parse(Console.ReadLine());
                if (sales[i, j] > highestSale)
                    highestSale = sales[i, j];
            }
        }

        Console.WriteLine("\nTotal Sales Per Branch:");
        for (int i = 0; i < branches; i++)
        {
            int total = 0;
            for (int j = 0; j < months; j++)
                total += sales[i, j];
            Console.WriteLine($"Branch {i}: {total}");
        }

        Console.WriteLine($"Highest Monthly Sale: {highestSale}");

        //    TASK 3 – JAGGED ARRAY

        int[][] jagged = new int[branches][];

        for (int i = 0; i < branches; i++)
        {
            int count = 0;
            for (int j = 0; j < months; j++)
                if (sales[i, j] >= averagePrice)
                    count++;

            jagged[i] = new int[count];
            int index = 0;

            for (int j = 0; j < months; j++)
                if (sales[i, j] >= averagePrice)
                    jagged[i][index++] = sales[i, j];
        }

        Console.WriteLine("\nJagged Array (Sales ≥ Product Average):");
        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write($"Branch {i}: ");
            foreach (int v in jagged[i])
                Console.Write(v + " ");
            Console.WriteLine();
        }

        //    TASK 4 – CUSTOMER TRANSACTIONS

        Console.Write("\nEnter number of customer transactions: ");
        int txnCount = int.Parse(Console.ReadLine());

        List<int> customers = new List<int>();
        for (int i = 0; i < txnCount; i++)
        {
            Console.Write("Enter customer ID: ");
            customers.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> uniqueCustomers = new HashSet<int>(customers);
        List<int> cleanedList = new List<int>(uniqueCustomers);

        Console.WriteLine("\nCleaned Customer IDs:");
        foreach (int id in cleanedList)
            Console.WriteLine(id);

        Console.WriteLine($"Duplicates Removed: {customers.Count - cleanedList.Count}");

        //    TASK 5 – FINANCIAL TRANSACTIONS

        Console.Write("\nEnter number of financial transactions: ");
        int financeCount = int.Parse(Console.ReadLine());

        Dictionary<int, double> finance = new Dictionary<int, double>();

        while (finance.Count < financeCount)
        {
            Console.Write("Enter Transaction ID: ");
            int id = int.Parse(Console.ReadLine());

            if (finance.ContainsKey(id))
            {
                Console.WriteLine("Duplicate ID not allowed.");
                continue;
            }

            Console.Write("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());
            finance.Add(id, amount);
        }

        SortedList<int, double> highValue = new SortedList<int, double>();
        foreach (var item in finance)
            if (item.Value >= averagePrice)
                highValue.Add(item.Key, item.Value);

        Console.WriteLine("\nHigh Value Transactions:");
        foreach (var item in highValue)
            Console.WriteLine($"ID: {item.Key}, Amount: {item.Value}");

        //    TASK 6 – STACK & QUEUE

        Console.Write("\nEnter number of operations: ");
        int ops = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < ops; i++)
        {
            Console.Write("Enter operation: ");
            string op = Console.ReadLine();
            queue.Enqueue(op);
            stack.Push(op);
        }

        Console.WriteLine("\nProcessing Queue:");
        while (queue.Count > 0)
            Console.WriteLine(queue.Dequeue());

        Console.WriteLine("\nUndo Operations:");
        for (int i = 0; i < 2 && stack.Count > 0; i++)
            Console.WriteLine(stack.Pop());

        
        //    TASK 7 – LEGACY COLLECTIONS

        Console.Write("\nEnter number of users: ");
        int users = int.Parse(Console.ReadLine());

        Hashtable table = new Hashtable();
        ArrayList list = new ArrayList();

        for (int i = 0; i < users; i++)
        {
            Console.Write("Enter username: ");
            string user = Console.ReadLine();

            Console.Write("Enter role: ");
            string role = Console.ReadLine();

            table[user] = role;
            list.Add(user);
            list.Add(role);
            list.Add(i); // mixed type
        }

        Console.WriteLine("\nHashtable Data:");
        foreach (DictionaryEntry entry in table)
            Console.WriteLine($"{entry.Key} → {entry.Value}");

        Console.WriteLine("\nArrayList Data (Mixed Types):");
        foreach (var item in list)
            Console.WriteLine(item);

        Console.WriteLine("\n ArrayList allows mixed data types → runtime risk.");

        Console.WriteLine("\n===== PROGRAM COMPLETED SUCCESSFULLY =====");
    }
}
