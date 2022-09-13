namespace SSSnake;

public static class Load
{
    public static TextureRegion Texture(string name)
    {
        return new(Resource.GetTextureById(name));
    }
}