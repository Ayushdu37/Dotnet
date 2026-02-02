using System;

public class Cleanser
{
    public static string CleanseAndInvert(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return "";
        }

        foreach (char ch in input)
        {
            if (!char.IsLetter(ch))
            {
                return "";
            }
        }

        input = input.ToLower();

        string temp = "";
        foreach (char ch in input)
        {
            int ascii = (int)ch;
            if (ascii % 2 != 0)
            {
                temp += ch;
            }
        }

        string reverse = "";
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            reverse += temp[i];
        }

        char[] result = reverse.ToCharArray();
        for (int i = 0; i < result.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[i] = char.ToUpper(result[i]);
            }
        }

        return new string(result);
    }
}
