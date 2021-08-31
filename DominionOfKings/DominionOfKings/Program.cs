using System;

int score;
int provinceValue = 6;
int duchyValue = 3;
int estateValue = 1;

//Console.Title = "Dominion of Kings";

Console.Write("Enter amount of provinces: ");
int provinces = Convert.ToInt32(Console.ReadLine());
int provinceScore = provinces * provinceValue;

Console.Write("Enter amount of duchies: ");
int duchies = Convert.ToInt32(Console.ReadLine());
int duchyScore = duchies * duchyValue;

Console.Write("Enter amount of estates: ");
int estates = Convert.ToInt32(Console.ReadLine());
int estateScore = estates * estateValue;

score = provinceScore + duchyScore + estateScore;
Console.WriteLine("Total points: " + score);

Console.WriteLine("Press any key to exit the program..");
Console.ReadKey(true);