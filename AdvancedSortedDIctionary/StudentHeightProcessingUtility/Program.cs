using System.Collections;
using System.Text;

public class Student
{
    public int Id{get;set;}
    public string Name{get;set;}
    public float? Height{get;set;}
    public float AttendancePercentage{get;set;}
}
public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student{Id = 101, Name = "Ayush", Height = 5.11F, AttendancePercentage = 89.00F});
        students.Add(new Student{Id = 102, Name = "Ritik", Height = 5.05F, AttendancePercentage = 100.00F});
        students.Add(new Student{Id = 103, Name = "Aryan", Height = 4.11F, AttendancePercentage = 99.52F});
        students.Add(new Student{Id = 104, Name = "Yash", Height = 9.10F, AttendancePercentage = 69.75F});
        students.Add(new Student{Id = 105, Name = "Karan", Height = null, AttendancePercentage = 95.50F});

        ArrayList list = new ArrayList(students);

        int attendanceCount = 0;
        foreach(var item in list)
        {
            Student s = (Student)item;

            Console.WriteLine($"Student: {GetAlternateCharacters(s.Name)}");

            if(s.Height == null)
            {
                Console.WriteLine("Height not available");
            }
            else
            {
                Console.WriteLine($"Height: {Math.Round(s.Height.Value, 1)}");
            }
            
            if(s.AttendancePercentage > 75.5)
            {
                Console.WriteLine($"Attendance Percentage: {s.AttendancePercentage}");
                attendanceCount++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine($"Total Students with attendance: {attendanceCount}");
    }
    public static string GetAlternateCharacters(string name)
    {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < name.Length; i += 2)
        {
            sb.Append(name[i]);
        }
        return sb.ToString();
    }
}