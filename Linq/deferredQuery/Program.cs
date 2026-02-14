using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        // // Creating a List
        // List<Student> students = new List<Student>();


        // // Adding students
        // students.Add(new Student { Id = 1, Name = "Ravi", Age = 20 });
        // students.Add(new Student { Id = 2, Name = "Kumar", Age = 22 });
        // students.Add(new Student { Id = 3, Name = "Priya", Age = 19 });

        // Console.WriteLine("Total Students: " + students.Count);
        // Console.WriteLine();

        // // Accessing by index
        // Console.WriteLine("First Student: " + students[0].Name);
        // Console.WriteLine();

        // // Updating student
        // students[1].Age = 23;

        // // Removing student
        // students.RemoveAt(2);

        // Console.WriteLine("After Update and Remove:");
        // Console.WriteLine("Total Students: " + students.Count);
        // Console.WriteLine();

        // // Sorting list by Age
        // students.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));

        // Console.WriteLine("Sorted by Age:");
        // foreach (var student in students)
        // {
        //     Console.WriteLine(student.Id + " - " + student.Name + " - " + student.Age);
        // }

        // Console.ReadLine();


        ArrayList list = new ArrayList()
        {
            1,
            "Mari",
            "MCA",
            20000
        };

        IEnumerable integers = list.OfType<int>();
        foreach(var num in integers)
        {
            Console.WriteLine(num);
        }

        string[] names = {"Ayush", "Ritik", "Aryan", "Karan", "Sparsh", "Shubhanshu", "Yash"};
        // IEnumerable<string> result = names.Where(name => name.StartsWith("A"));
        // foreach(var name in result)
        // {
        //     Console.WriteLine(name);
        // }
        // IEnumerable nam = names.Where(n => n.EndsWith("u")).Select(n => "Mr " + n);
        // foreach(var n in nam)
        // {
        //     Console.WriteLine(n);
        // }

        // var skip = names.SkipWhile(n => n.StartsWith("A"));
        // foreach(var name in skip)
        // {
        //     Console.WriteLine(name);
        // }

        // List<int> numbers = new List<int>{1,2,3,4,5};
        // IEnumerable<int> result = numbers.Where(x => x > 2);
        // numbers.Add(10);
        // foreach(var n in result)
        // {
        //     Console.WriteLine(n);
        // }

        Expression<Func<int, bool>> expr = x => x > 2;
        Console.WriteLine($"Body: {expr.Body}");
        Console.WriteLine($"Body type: {expr.Body.GetType()}");
        Console.WriteLine($"Parameters: {expr.Parameters}");
        Console.WriteLine($"Node Type: {expr.NodeType}");

        var compile = expr.Compile();
        bool result = compile(10);




    }
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}