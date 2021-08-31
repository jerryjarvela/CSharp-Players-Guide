using System;

int manticoreHealth = 10;
int cityHealth = 15;
int manticoreMaxHealth = 10;
int cityMaxHealth = 15;
int gameRoundStart = 1;
bool gameEnd = false;

while (manticoreHealth != 0 || cityHealth != 0)
{
    int manticoreDistance = AskPlayerOneDistance("Player 1, how far away from the city do you want to station the Manticore? (0-100) ", 0, 100);

    int AskPlayerOneDistance(string text, int min, int max)
    {
        while (true)
        {
            int number = AskForNumber(text);
            if (number >= min && number <= max)
            {
                Console.Clear();
                return number;
            }
        }
    }

    int AskForNumber(string text)
    {
        Console.WriteLine(text + " ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    CannonDamage(manticoreHealth);
    NextRound();
}

int CannonDamage(int manticoreHealth)
{
    Random rnd = new Random();
    int randomDamage = rnd.Next(1, 3);
    Console.WriteLine($"The cannon deals {randomDamage} damage!");
    return manticoreHealth - randomDamage;
}

void NextRound()
{
    Console.WriteLine("------------------------------------------------");
    Console.Write("STATUS: ");
    Console.Write($"Round: {gameRoundStart++} ");
    Console.Write($"City: {cityHealth}/{cityMaxHealth} ");
    Console.WriteLine($"Manticore: {manticoreHealth}/{manticoreMaxHealth} ");
    Console.WriteLine("------------------------------------------------");
    Console.ReadKey(true);
}

Console.WriteLine("You lost!");