namespace SSSnake.Types;

public class SnakeType : GameContent
{
    public TextureRegion Head, Tail, Body;

    public SnakeType(string name) : base(name, ContentType.Snake)
    {
    }

    public override void LoadResource()
    {
        base.LoadResource();
        Head = Load.Texture($"{Name}-head");
        Body = Load.Texture($"{Name}-body");
        Tail = Load.Texture($"{Name}-tail");
    }
}