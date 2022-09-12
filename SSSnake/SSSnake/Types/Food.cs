using Microsoft.Xna.Framework;

namespace SSSnake.Types;

public class Food : GameContent
{
    public TextureRegion Tex;

    public Food(string name) : base(name, ContentType.Food)
    {
    }

    public override void LoadResource()
    {
        base.LoadResource();
        Tex = Load.Texture($"{Name}");
    }
}