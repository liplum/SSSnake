#nullable enable
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using SSSnake.Components;
using SSSnake.Entities;

namespace SSSnake;

public class GameObject
{
    private static int _globalId;
    public int Id = _globalId++;
    public bool IsAdded { get; private set; }

    public virtual void Add()
    {
        if (!IsAdded)
        {
            Group.Entites.Add(Id, this);
            if (this is IDrawComp drawComp) Group.Drawables.Add(drawComp);
            if (this is IUpdateComp updateComp) Group.Updateables.Add(updateComp);
            if (this is ISyncComp syncComp) Group.Syncs.Add(syncComp);
            IsAdded = true;
        }
    }
}