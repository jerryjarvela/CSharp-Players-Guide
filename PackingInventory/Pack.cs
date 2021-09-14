using System;

public class Pack
{
    public int MaxCount { get; }
    public float MaxVolume { get; }
    public float MaxWeight{ get; }

    private readonly InventoryItem[] _items;

    public int CurrentCount { get; private set; }
    public float CurrentVolume { get; private set; }
    public float CurrentWeight { get; private set; }

    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        MaxCount = maxCount;
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;

        _items = new InventoryItem[maxCount];
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentCount >= MaxCount) return false;
        if (CurrentVolume + item.ItemVolume > MaxVolume) return false;
        if (CurrentWeight+ item.ItemWeight > MaxWeight) return false;

        _items[CurrentCount] = item;
        CurrentCount++;
        CurrentWeight += item.ItemVolume;
        CurrentWeight += item.ItemWeight;
        return true;
    }

    public override string ToString()
    {
        string contents = "Pack containing: ";
        if (CurrentCount == 0) contents += "Nothing";

        for (int itemNumber = 0; itemNumber < CurrentCount; itemNumber++)
        {
            contents += _items[itemNumber].ToString() + " ";
        }

        return contents;
    }
}