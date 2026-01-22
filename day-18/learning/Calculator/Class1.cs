namespace Calculator;

interface I1
{
    void m1(double x, double y);
}

interface I2
{
    void m2(double x, double y);
}

class ClassA : I1
{
    public void m1(double x, double y)
    {
        Console.WriteLine("m1 from ClassA is called");
    }
}
class ClassB : ClassA, I2
{
    public void m2(double x, double y)
    {
        Console.WriteLine("m2 from ClassB is called");
    }
}