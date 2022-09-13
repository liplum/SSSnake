using System;
using System.Collections.Generic;

namespace SSSnake;

public enum ContentType
{
    Snake = 0,
    Food = 1,
    Block = 2
}

public abstract class GameContent
{
    public static List<GameContent>[] All;

    static GameContent()
    {
        All = new List<GameContent>[3];
        for (var i = 0; i < All.Length; i++)
        {
            All[i] = new();
        }
    }

    public readonly string Name;

    public readonly ContentType Type;

    public GameContent(string name, ContentType type)
    {
        Name = name;
        Type = type;
        All[(int)type].Add(this);
    }


    public virtual void LoadResource()
    {
    }

    public virtual void Init()
    {
    }
}