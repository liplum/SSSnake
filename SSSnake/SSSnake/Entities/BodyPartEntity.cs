using Microsoft.Xna.Framework;
using SSSnake.Components;
using SSSnake.Math;
using PointH = SSSnake.Core.PointH;

namespace SSSnake.Entities;

public enum BodyPartType
{
    Head,
    Body,
    Tail
}

public class BodyPartEntity : GameObject, IUpdateComp, IDrawComp, IPosComp
{
    public SnakeEntity Snake { get; set; }
    public Point Pos { get; set; }
    public int Direction { get; set; }
    public Point PrePos { get; set; }
    public int PreDirection { get; set; }
    public BodyPartEntity LinkedBody;
    public BodyPartType BodyPartType;

    public void Update()
    {
        if (Snake.CanBodyMove && LinkedBody != null)
        {
            Pos = LinkedBody.PrePos;
            Direction = LinkedBody.PreDirection;
        }
    }

    public void Draw()
    {
        
    }
}