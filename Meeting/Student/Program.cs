using System;
using System.Collections.Generic;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
}

public class StudentUtility
{
    public Dictionary<string, string> GetStudentDetails(string id)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();

        foreach (var item in Program.studentDetails.Values)
        {
            if (item.Id == id)
            {
                result.Add(item.Id, item.Name + "_" + item.Course);
                break;
            }
        }

        return result;
    }

    public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
    {
        Dictionary<string, Student> result = new Dictionary<string, Student>();

        foreach (var item in Program.studentDetails.Values)
        {
            if (item.Id == id)
            {
                item.Marks = marks;
                result.Add(item.Id, item);
                break;
            }
        }

        return result;
    }
}

public class Program
{
    public static Dictionary<int, Student> studentDetails;

    public static void Main(string[] args)
    {
        studentDetails = new Dictionary<int, Student>()
        {
            { 1, new Student { Id = "ST01", Name = "Alice", Course = "DataScience", Marks = 85 } },
            { 2, new Student { Id = "ST02", Name = "Bob", Course = "Java", Marks = 78 } }
        };

        StudentUtility utility = new StudentUtility();
        bool exit = true;

        while (exit)
        {
            Console.WriteLine("1. Get Student Details");
            Console.WriteLine("2. Update Marks");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the student id");
                    string id = Console.ReadLine();

                    var details = utility.GetStudentDetails(id);

                    if (details.Count == 0)
                    {
                        Console.WriteLine("Student id not found");
                    }
                    else
                    {
                        foreach (var d in details)
                        {
                            Console.WriteLine(d.Key + "   " + d.Value);
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter the student id");
                    string updateId = Console.ReadLine();

                    Console.WriteLine("Enter the marks");
                    int marks = int.Parse(Console.ReadLine());

                    var updated = utility.UpdateStudentMarks(updateId, marks);

                    if (updated.Count == 0)
                    {
                        Console.WriteLine("Student id not found");
                    }
                    else
                    {
                        foreach (var u in updated)
                        {
                            Console.WriteLine(u.Key + "   " + u.Value.Marks);
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Thank you");
                    exit = false;
                    break;
            }
        }
    }
}
