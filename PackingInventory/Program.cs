using System;

Pack pack = new Pack(10, 20, 30);

while (true)
{
    Console.WriteLine($"Pack is currently at {pack.CurrentCount}/{pack.MaxCount} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, and {pack.CurrentVolume}/{pack.MaxVolume} volume.");

    Console.WriteLine("What do you want to add?");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");
    int choice = Convert.ToInt32(Console.ReadLine());

    InventoryItem newItem = choice switch
    {
        1 => new InventoryItem.Arrow(),
        2 => new InventoryItem.Bow(),
        3 => new InventoryItem.Rope(),
        4 => new InventoryItem.Water(),
        5 => new InventoryItem.Food(),
        6 => new InventoryItem.Sword()
    };

    if (!pack.Add(newItem))
    {
        Console.WriteLine("Could not add this to the pack.");
    }
}