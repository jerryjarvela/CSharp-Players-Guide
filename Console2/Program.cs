using System;

Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Deployed to: {targetRow}, {targetColumn -= 1}");
Console.WriteLine($"Deployed to: {targetRow -= 1}, {targetColumn += 1}");
Console.WriteLine($"Deployed to: {targetRow += 1}, {targetColumn += 1}");
Console.WriteLine($"Deployed to: {targetRow += 1}, {targetColumn -= 1}");
Console.Beep();

Console.ReadKey(true);