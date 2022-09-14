using Microsoft.Xna.Framework;
using MonoGame.Extended.TextureAtlases;

namespace SSSnake.Types;

public class Food : GameContent
{
    public TextureRegion2D Tex;

    public Food(string name) : base(name, ContentType.Food)
    {
    }

    public override void LoadResource()
    {
        base.LoadResource();
        Tex = Load.Texture($"{Name}");
    }
}