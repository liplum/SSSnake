using MonoGame.Extended.TextureAtlases;

namespace SSSnake;

public static class Load
{
    public static TextureRegion2D Texture(string name)
    {
        return Resource.GetTextureById(name);
    }
}