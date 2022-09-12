using System;
using Microsoft.Xna.Framework;
using SSSnake.Components;
using SSSnake.Types;

namespace SSSnake.Entities;

public class SnakeEntity : GameObject
{
    public bool CanBodyMove { get; }
    public int Direction { get; }

    public SnakeType Type;

}