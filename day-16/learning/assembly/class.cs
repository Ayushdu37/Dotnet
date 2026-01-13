public class Demo
{
    private int _salary = 10000;
    public string Name;
    public int Age;


    public void ShowSalary()
    {
        Console.WriteLine(_salary);
    }
    public Demo(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Show()
    {
        Console.WriteLine($"{Name} - {Age} - {_salary}");
    }
}