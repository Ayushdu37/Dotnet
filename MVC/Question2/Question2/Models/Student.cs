namespace Question2.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int AgeSquare => Age * Age;
    }
}
