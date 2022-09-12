namespace SSSnake.Types;

public class Block : GameContent
{
    public Block(string name) : base(name, ContentType.Block)
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
}