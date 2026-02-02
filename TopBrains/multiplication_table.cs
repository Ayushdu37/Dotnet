using System;

Console.Write("Enter the n number: ");
int input = int.Parse(Console.ReadLine());

Console.Write("Enter the upto number: ");
int upto = int.Parse(Console.ReadLine());

int[] row = new int[upto];
for(int i=0; i<upto; i++)
{
    row[i] = input * (i+1);
}

for(int i = 0; i < row.Length; i++)
{
    Console.Write($"{row[i]}, ");
}