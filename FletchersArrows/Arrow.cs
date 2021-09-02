class Arrow
{
    //private Arrowhead _arrowhead;
    //private Fletching _fletching;
    //private float _length;

    public Arrowhead Arrowhead { get; }
    public Fletching Fletching { get; }
    public float Length { get; }

    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);
    public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.Obsidian, Fletching.TurkeyFeathers, 95);

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public float GetCost()
    {
        float arrowheadCost = Arrowhead switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5
        };

        float fletchingCost = Fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };

        float shaftCost = 0.05f * Length;

        return arrowheadCost + fletchingCost + shaftCost;
    }
}

enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }