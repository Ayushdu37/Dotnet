using System;

double radius = double.Parse(Console.ReadLine());

double area = 3.14 * radius * radius;

double result = area;
Console.WriteLine($"{result:F2}");