using System.Numerics;

namespace SSSnake.Types;

public class Block : GameContent
{
    public Block(string name) : base(name, ContentType.Block)
    {
    }

    public virtual void Draw(Tile tile)
    {
    }
}

public class Air : Block
{
    public Air(string name) : base(name)
    {
    }
}

public class BackgroundBlock : Block
{
    public TextureRegion Tex;

    public BackgroundBlock(string name) : base(name)
    {
    }

    public override void LoadResource()
    {
        base.LoadResource();
        Tex = Load.Texture($"{Name}");
    }

    public override void Draw(Tile tile)
    {
        Core.Draw.Tex(Tex, new Vector2(tile.X, tile.Y));
    }
}