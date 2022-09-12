using System;
using Microsoft.Xna.Framework;
using SSSnake.Components;

namespace SSSnake.Entities;

public class SnakeEntity : GameObject
{
    public bool CanBodyMove { get; }
    public int Direction { get; }

    public override void InitComponents()
    {
        base.InitComponents();
        AddComp<IGameComponent>(new SnakeComp());
        AddComp<ISnakeControllerComp>(new SnakeComp());
    }

    public class SnakeComp : IGameComponent
    {
        public void Initialize()
        {
        }
    }
}