// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Product p = new Product
// {
//     Name = "Laptop",
//     Price = 50000
// };

// Console.WriteLine(p.Name);
// Console.WriteLine(p.Price);

// Student student = new Student(5001)
// {
//     Admission_year = 2023
// };

// student.Name = "Ayush";
// student.Age = 21;
// student.Marks = 90;
// student.Password = "37Ayush@73";

// Console.WriteLine($"Student Id : {student.StudentId}");
// Console.WriteLine($"Name : {student.Name}");
// Console.WriteLine($"Age : {student.Age}");
// Console.WriteLine($"Marks : {student.Marks}");
// // Console.WriteLine($"Password : {student.Password}");
// Console.WriteLine($"Result : {student.Result}");
// Console.WriteLine($"Percentage : {student.Percentage}");
// Console.WriteLine($"Admission Year : {student.Admission_year}");
// Console.WriteLine($"Registration No. : {student.Reg}");


// Library user = new Library();
// user[1] = "Ayush";
// user[2] = "Yash";
// user[3] = "Hori San";

// Console.WriteLine(user[1]);
// Console.WriteLine(user["Yash"]);
// Console.WriteLine(user[4]); // Outpur = Unhandled exception. System.Collections.Generic.KeyNotFoundException: The given key '4' was not present in the dictionary.

// Car c = new Car();
// c.Start();   // inherited method
// c.Drive();   // own method

// Insurance Management System

Security security = new Security();
security.Authenticate("Amit", "1234");


InsurancePolicy life = new LifeInsurance
{
    PolicyNumber = 102,
    PolicyHolder = "Amit",
    Premium = 5000
};

InsurancePolicy health = new HealthInsurance
{
    PolicyNumber = 103,
    PolicyHolder = "Amit",
    Premium = 7500
};

PolicyDirectory directory = new PolicyDirectory();
directory[102] = life;
directory[103] = health;

Console.WriteLine("Life Premium : " + life.CalculatePremium());
Console.WriteLine("Health Premiuim : " + life.CalculatePremium());

LifeInsurance derivedRef = new LifeInsurance();
InsurancePolicy baseRef = derivedRef;

derivedRef.DisplayPolicy();
baseRef.DisplayPolicy();



