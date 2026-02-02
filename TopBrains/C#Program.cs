using System;

Console.Write("Enter the first number: ");
string first = Console.ReadLine();

Console.Write("Enter the second number: ");
string second = Console.ReadLine();

string temp = "";

foreach(char c in first)
{
    char lowerC = char.ToLower(c);

    bool isVowel = lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';

    if (isVowel)
    {
        temp += c;
    }
    else
    {
        bool found = false;

        foreach(char s in second)
        {
            if(lowerC == char.ToLower(s))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            temp +=c;
        }
    }
}

string result = "";

for(int i = 0; i < temp.Length; i++)
{
    if(i == 0 || temp[i] != temp[i - 1])
    {
        result += temp[i];
    }
}

Console.WriteLine($"Final string: {result}");