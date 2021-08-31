using System;

int[] original = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    original[i] = number;
}

int[] copy = new int[5];

for (int i = 0; i < 5; i++)
{
    copy[i] = original[i];
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{original[i]} and {copy[i]}");
}

Console.WriteLine("Press any key to continue..");
Console.ReadKey(true);

int[] arrayTwo = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentMinimum = int.MaxValue; // Start higher than anything in the array. 

foreach (int i in arrayTwo)
{
    if (i < currentMinimum)
    {
        currentMinimum = i;
    }
}
Console.WriteLine(currentMinimum);

int total = 0;
foreach (int i in arrayTwo)
{
    total += i;
}
float average = (float)total / arrayTwo.Length;
Console.WriteLine(average);