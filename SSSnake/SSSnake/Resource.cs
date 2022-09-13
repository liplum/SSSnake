using System.Collections.Generic;

namespace SSSnake;

public static class Resource
{
    public static readonly string ErrorName = "error";
    public static TextureRegion Error;
    public static Dictionary<string, TextureRegion> Textures = new();
    public static TextureRegion GetTextureById(string name) {
        if (Textures.TryGetValue(name, out var tex))
            return tex;
        else
            return Error;
    }
}