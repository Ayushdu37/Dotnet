using System;

Console.Write("Enter the size of the array: ");
int size = int.Parse(Console.ReadLine());

int[] nums = new int[size];
int sum = 0;
for(int i = 0; i < nums.Length; i++)
{
    nums[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i < nums.Length; i++)
{
    if(nums[i] == 0) break;
    if(nums[i] < 0) continue;
    sum += nums[i];
}

Console.WriteLine($"Sum = {sum}");