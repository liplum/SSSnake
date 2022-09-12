using System.Collections.Generic;
using SSSnake.Components;

namespace SSSnake;

public class Group
{
    public static Dictionary<int, GameObject> Entites = new();
    public static HashSet<IUpdateComp> Updateables = new ();
    public static HashSet<IDrawComp> Drawables = new();
    public static HashSet<ISyncComp> Syncs = new();
}