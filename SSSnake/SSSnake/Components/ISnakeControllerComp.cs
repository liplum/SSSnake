using Microsoft.Xna.Framework;

namespace SSSnake.Components;

public interface ISnakeControllerComp : IGameComponent
{
    public int Direction { get; }
}