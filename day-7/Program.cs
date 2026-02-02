// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// Payroll program = new Payroll();

// bool check = true;
// while (check)
// {
//     Console.WriteLine("1. Register Employee");
//     Console.WriteLine("2. Show Overtime Summary");
//     Console.WriteLine("3. Calculate Average Monthly Pay");
//     Console.WriteLine("4. Exit");

//     Console.Write("Enter your choice : ");
//     int choice = int.Parse(Console.ReadLine());

//     switch (choice)
//     {
//         case 1:
//             Console.Write("Select Employee Type (1-Full Time, 2-Contract): ");
//             int type = int.Parse(Console.ReadLine());

//             Console.Write("Enter Employee Name: ");
//             string name = Console.ReadLine();

//             Console.Write("Enter Hourly Rate: ");
//             double rate = double.Parse(Console.ReadLine());


//             Console.WriteLine("Enter Weekly Hours (Week 1 to 4): ");
//             double[] hours = new double[4];
//             for(int i = 0; i < hours.Length; i++)
//             {
//                 hours[i] = double.Parse(Console.ReadLine());
//             }

//             if(type == 1)
//             {
//                 Console.Write("Enter Monthly Bonus: ");
//                 double bonus = double.Parse(Console.ReadLine());

//                 FullTimeEmployee fte = new FullTimeEmployee();
//                 fte.EmployeeName = name;
//                 fte.HourlyRate = rate;
//                 fte.MonthlyBonus = bonus;
//                 fte.WeeklyHours = hours;

//                 program.RegisterEmployee(fte);
//             }
//             else if(type == 2)
//             {
//                 ContractEmployee ce = new ContractEmployee();
//                 ce.EmployeeName = name;
//                 ce.HourlyRate = rate;
//                 // ce.MonthlyBonus = bonus;
//                 ce.WeeklyHours = hours;

//                 program.RegisterEmployee(ce);   
//             }

//             Console.WriteLine("Employee Registered Successfully.");
//             break;

//         case 2:
//             Console.Write("Enter hours threshold: ");
//             double threshold = double.Parse(Console.ReadLine());
//             Dictionary<string, int> overtimeResult = program.GetOvertimeWeekCounts(Payroll.PayrollBoard, threshold);

//             if(overtimeResult.Count == 0)
//             {
//                 Console.WriteLine("No Overtime recorded this month");
//             }
//             else
//             {
//                 foreach(var item in overtimeResult)
//                 {
//                     Console.WriteLine($"{item.Key} - {item.Value}");
//                 }
//             }
//             break;

//         case 3:
//             double averagePay = program.CalculateAverageMonthlyPay();
//             Console.WriteLine($"Overall average monthly pay: {averagePay}");
//             break;

//         case 4:
//             check = false;
//             Console.WriteLine("Logging off - Payroll processed successfully!");
//             break;
//     }
// }

Console.WriteLine("Enter the word");
string input = Console.ReadLine();

string password = Cleanser.CleanseAndInvert(input);

if (password == "")
{
    Console.WriteLine("Invalid Input");
}
else
{
    Console.WriteLine("The generated key is - " + password);
}