class Student
{
    public String Name{get; set;}
    public int Marks{get; set;}
}

class Program
{
    public static void Main()
    {
        Student student = new Student
        {
            Name = "Ayush",
            Marks = 96
        };
        var result = student.Select(s => new
        {
            s.Name,
            Grade = s.Marks > 60 ? "Pass" : "Fail"
        }); 
        result.GetType();
    }
}