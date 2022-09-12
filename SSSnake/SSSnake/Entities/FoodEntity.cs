using Microsoft.Xna.Framework;
using SSSnake.Components;
using SSSnake.Types;

namespace SSSnake.Entities;

public class FoodEntity : GameObject, IPosComp
{
    public Food Type { get; }
    public Point Pos { get; set; }
}