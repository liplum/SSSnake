using Microsoft.Xna.Framework;

namespace SSSnake.Components;

public interface IPosComp : IGameComponent
{
    public Point Pos { get; set; }
}

public class PosComp : IPosComp
{
    public Point Pos { get; set; }

    public virtual void Initialize()
    {
    }
}