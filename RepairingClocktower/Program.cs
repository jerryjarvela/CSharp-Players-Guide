using System;

int userInput = Convert.ToInt32(Console.ReadLine());

if (userInput % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}

int userInputX = Convert.ToInt32(Console.ReadLine());
int userInputY = Convert.ToInt32(Console.ReadLine());

// Northwest, west, southwest
if (userInputY > 0 && userInputX < 0)
{
    Console.WriteLine("Northwest");
}
else if (userInputY == 0 && userInputX < 0)
{
    Console.WriteLine("West");
}
else if (userInputY < 0 && userInputX < 0)
{
    Console.WriteLine("Southwest");
}

//North, HERE, South
else if (userInputY > 0 && userInputX == 0)
{
    Console.WriteLine("North");
}
else if (userInputY == 0 && userInputX == 0)
{
    Console.WriteLine("The enemy is here!");
}
else if (userInputY < 0 && userInputX == 0)
{
    Console.WriteLine("South");
}

// Northeast, East, Southeast
else if (userInputY > 0 && userInputX == 0)
{
    Console.WriteLine("Northeast");
}
else if (userInputY == 0 && userInputX > 0)
{
    Console.WriteLine("East");
}
else if (userInputY < 0 && userInputX > 0)
{
    Console.WriteLine("Southeast");
}