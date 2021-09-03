using System;

Point a = new Point(2, 3);
Point b = new Point(-4, 0);

Console.WriteLine($"({a.X}, {a.Y})");
Console.WriteLine($"({b.X}, {b.Y})");

Color colorOne = new Color(128, 0, 128);
Color colorTwo = Color.Yellow;

Console.WriteLine($"R = {colorOne.RedRGB}, G = {colorOne.GreenRGB}, B = {colorOne.BlueRGB}"); 
Console.WriteLine($"R = {colorTwo.RedRGB}, G = {colorTwo.GreenRGB}, B = {colorTwo.BlueRGB}");

Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
Rank[] ranks = new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };

foreach (Color color in colors)
{
    foreach (Rank rank in ranks)
    {
        Card card = new Card(rank, color);
        Console.WriteLine($"The {card.Color} {card.Rank}");
    }
}