using System;

int number;

do
{
    Console.WriteLine("User 1, enter a number between 0 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());
} while (number < 0 || number > 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (true)
{
    Console.WriteLine("What is your next guess?");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess > number)
    {
        Console.WriteLine($"{guess} is too high.");
    }
    else if (guess < number)
    {
        Console.WriteLine($"{guess} is too low.");
    }
    else
    {
        break;
    }
}

Console.WriteLine("You guessed the number!");
Console.WriteLine("Press anywhere to continue to The Magic Cannon..");
Console.ReadKey(true);
Console.Clear();

for (int i = 1; i <= 100; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Super blast!");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Electric");
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Normal");
    }
}

Console.ReadKey(true);