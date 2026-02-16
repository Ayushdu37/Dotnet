using BLCalc;

ReverseString names = new ReverseString();
List<string> revrerseNames = names.ReverseNames();
Console.WriteLine("Reversed Names List: \n");
foreach(string name in revrerseNames)
{
    Console.WriteLine(name);
}
Console.ReadLine();