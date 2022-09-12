using Microsoft.Xna.Framework;
using SSSnake.Components;
using SSSnake.Math;

namespace SSSnake.Entities;

public class BodyPartEntity : GameObject
{
    public SnakeEntity Snake { get; set; }

    public override void InitComponents()
    {
        base.InitComponents();
        var body = new BodyEntityComp(this);
        AddComp<IGameComponent>(body);
        AddComp<IPosComp>(new PosComp());
    }

    public class BodyEntityComp : DrawableEntityComp
    {
        public readonly BodyPartEntity Entity;

        public BodyEntityComp(BodyPartEntity entity)
        {
            Entity = entity;
        }

        public override void Update(GameTime gameTime)
        {
            if (Entity.Snake.CanBodyMove)
            {
                var pos = Entity.GetComponent<IPosComp>()!;
                pos.Pos = pos.Pos.Step(Entity.Snake.Direction);
            }
        }

        public override void Draw(GameTime gameTime)
        {
        }
    }
}