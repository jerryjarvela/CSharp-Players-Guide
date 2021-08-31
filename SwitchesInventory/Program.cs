using System;

string rope = "Rope";
string torches = "Torches";
string climbingEquipment = "Climbing Equipment";
string cleanWater = "Clean Water";
string machete = "Machete";
string canoe = "Canoe";
string foodSupplies = "FoodSupplies";
int ropePrice = 5;
int torchPrice = 15;
int climbingEquipmentPrice = 30;
int cleanWaterPrice = 3;
int machetePrice = 10;
int canoePrice = 75;
int foodSuppliesPrice = 3;

Console.WriteLine("Howdy matey! What number do you want to see the price of?");
Console.WriteLine("The following items are available:");
Console.WriteLine($"1 - {rope}");
Console.WriteLine($"2 - {torches}");
Console.WriteLine($"3 - {climbingEquipment}");
Console.WriteLine($"4 - {cleanWater}");
Console.WriteLine($"5 - {machete}");
Console.WriteLine($"6 - {canoe}");
Console.WriteLine($"7 - {foodSupplies}");

Console.Write("Your input: ");
int userInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tell me matey, what's your name?");
Console.Write("Your input: ");
string nameInput = Console.ReadLine();

if (nameInput == "Jerry")
{
    ropePrice /= 2;
    torchPrice /= 2;
    climbingEquipmentPrice /= 2;
    cleanWaterPrice /= 2;
    machetePrice /= 2;
    canoePrice /= 2;
    foodSuppliesPrice /= 2;
}

switch (userInput)
{
    case 1:
        Console.WriteLine($"{rope} costs {ropePrice} gold.");
        break;
    case 2:
        Console.WriteLine($"{torches} costs {torchPrice} gold.");
        break;
    case 3:
        Console.WriteLine($"{climbingEquipment} costs {climbingEquipmentPrice} gold.");
        break;
    case 4:
        Console.WriteLine($"{cleanWater} costs {cleanWaterPrice} gold.");
        break;
    case 5:
        Console.WriteLine($"{machete} costs {machetePrice} gold.");
        break;
    case 6:
        Console.WriteLine($"{canoe} costs {canoePrice} gold.");
        break;
    case 7:
        Console.WriteLine($"{foodSupplies} costs {foodSuppliesPrice} gold.");
        break;
    default:
        Console.WriteLine("Nothing you fancy? Ah well, goodbye.");
        break;
}

Console.ReadKey(true);