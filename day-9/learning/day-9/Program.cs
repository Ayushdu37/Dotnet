// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.IO;

class Program
{
    public static void Main()
    {
        //    try
        //    {
        //        //User Input validation
        //        Console.WriteLine("Enter the Withdraw amount");
        //        decimal amount = decimal.Parse(Console.ReadLine());

        //        //Arithemic Operation
        //        int serviceCharge = 100;
        //        int devisorCheck = serviceCharge / int.Parse("0");

        //        //File access
        //        string data = File.ReadAllText("account.txt");

        //        BankAccount account = new BankAccount();
        //        account.Withdraw(amount);

        //        Console.WriteLine("Withdraw is successfull.");


        //    }
        //    catch (FormatException ex)
        //    {
        //        LogException(ex);
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        LogException(ex);
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        LogException(ex);
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (InsufficientMemoryException ex)
        //    {
        //        LogException(ex);
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        LogException(ex);
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Transaction attempt is completed");
        //    }
        //}

        //static void LogException(Exception ex)
        //{
        //    File.AppendAllText("error.log",
        //        DateTime.Now + " | " + ex.GetType().Name + " | " + ex.Message + Environment.NewLine
        //    );
        //}


        //FileStream file = null;
        //try
        //{
        //    file = new FileStream("data.txt", FileMode.Open);
        //    int data = file.ReadByte();
        //}
        //catch(FileNotFoundException ex)
        //{
        //    Console.WriteLine("File not found: " + ex.Message);
        //}
        //finally
        //{
        //    if(file != null)
        //    {
        //        file.Close();
        //        Console.WriteLine("File stream closed in finally block.");
        //    }
        //}

        //try
        //{
        //    // Simulate database operation
        //    throw new SqlException("Connection failed");
        //}
        //catch (SqlException ex)
        //{
        //    // Wrap low-level exception into higher-level exception
        //    throw new Exception("Database operation failed in Service Layer", ex);
        //}

        //try
        //{
        //    try
        //    {
        //        File.ReadAllText("transactions.txt");
        //    }catch(IOException ioEx) // Techinal Layer
        //    {
        //        throw new ApplicationException( // Business Layer
        //            "Unable to load transaction data."
        //            , ioEx); // Exception Wrapping
        //    }
        //}catch(Exception ex)
        //{
        //    Console.WriteLine("Message: " + ex.Message);
        //    Console.WriteLine("Root cause: " + ex.InnerException.Message);
        //}


    }
}