using System;

Chest currentChestState = Chest.Lock;
string playerChoice;

Console.Write($"The chest is locked. What do you want to do? ");

while (true)
{
    playerChoice = Console.ReadLine();

    if (playerChoice == Chest.Unlock.ToString())
    {
        Console.Write($"The chest is unlocked. What do you want to do? ");
    }
    else if (playerChoice == Chest.Open.ToString())
    {
        Console.Write($"The chest is opened. What do you want to do? ");
    }
    else if (playerChoice == Chest.Close.ToString())
    {
        Console.Write($"The chest is closed. What do you want to do? ");
    }
    else if (playerChoice == Chest.Lock.ToString())

    {
        Console.Write($"The chest is locked. What do you want to do? ");
    }
}

enum Chest
{
    Lock,
    Unlock,
    Open,
    Close
}