using System.Collections.Generic;
using MonoGame.Extended.TextureAtlases;

namespace SSSnake;

public static class Resource
{
    public static readonly string ErrorName = "error";
    public static TextureRegion2D Error;
    public static Dictionary<string, TextureRegion2D> Textures = new();
    public static TextureRegion2D GetTextureById(string name)
    {
        return Textures.TryGetValue(name, out var tex) ? tex : Error;
    }
}