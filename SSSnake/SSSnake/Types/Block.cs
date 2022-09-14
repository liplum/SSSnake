using System.Numerics;
using MonoGame.Extended.TextureAtlases;

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
    public TextureRegion2D Tex;

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
        Drawf.Tex(Tex, tile.DrawXy);
    }
}