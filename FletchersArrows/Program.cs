using System;

Console.WriteLine("What arrow do you want?");
Console.WriteLine("1 - Beginner Arrow");
Console.WriteLine("2 - Marksman Arrow");
Console.WriteLine("3 - Elite Arrow");
Console.WriteLine("4 - Custom Arrow");

string playerChoice = Console.ReadLine();

Arrow arrow = playerChoice switch
{
    "1" => Arrow.CreateBeginnerArrow(),
    "2" => Arrow.CreateMarksmanArrow(),
    "3" => Arrow.CreateEliteArrow(),
    "4" => CreateCustomArrow()
};

Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");


Arrow CreateCustomArrow()
{
    Arrowhead arrowhead = GetArrowheadType();
    Fletching fletching = GetFletchingType();
    float length = GetLength();

    return new Arrow(arrowhead, fletching, length);
}

Arrowhead GetArrowheadType()
{
    Console.Write("Arrowhead type (steel, wood, obsidian): ");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian
    };
}

Fletching GetFletchingType()
{
    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feather" => Fletching.TurkeyFeathers,
        "goose feather" => Fletching.GooseFeathers
    };
}

float GetLength()
{
    float length = 0;

    while (length < 60 || length > 100)
    {
        Console.Write("Arrow length (between 60 and 100): ");
        length = Convert.ToSingle(Console.ReadLine());
    }

    return length;
}