using System;
using System.Collections.Generic;

public class Student
{
    public string? Name;
    public int Age;
    public int Marks;
    public Student(){}
}
class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student{Name="Ayush",Age=22,Marks=95},
            new Student{Name="Ritik",Age=21,Marks=90},
            new Student{Name="Aryan",Age=23,Marks=93},
            new Student{Name="Yash",Age=22,Marks=93},
            new Student{Name="Rajiv",Age=21,Marks=91},
        };

        // var result = studentlist.OrderByDescending(it => it.Marks).ThenBy( k => k.Age).ToList();
        // studentlist=result;

        // studentlist.Sort((a,b) =>
        // {
        //     int cmp = b.Marks.CompareTo(a.Marks);
        //     return cmp!=0? cmp: a.Age.CompareTo(b.Age);
        // });

        students.Sort(new Cmp());
        foreach(var item in students)
        {
            Console.WriteLine($"Name:{item.Name} Marks:{item.Marks} Age:{item.Age}");
        }

    }
    internal class Cmp : IComparer<Student>
    {
        public int Compare(Student? a, Student? b)
        {
            if(a == null && b == null) return 0;
            if(a == null) return -1;
            if(b == null) return -1;
            int cmp = b.Marks.CompareTo(a.Marks);
            return cmp!=0? cmp: a.Age.CompareTo(b.Age);
        }
    }
}