using System.Reflection.Metadata.Ecma335;
using Microsoft.Xna.Framework.Graphics;

namespace SSSnake.Core;

public class TextureRegion
{
    public TextureRegion(){}

    public TextureRegion(TextureRegion original)
    {
        Texture = original.Texture;
        Width = original.Width;
        Height = original.Height;
        X = original.X;
        Y = original.Y;
    }
    public Texture2D Texture;
    public int Width, Height;
    public int X, Y;
    public bool IsCropped => Texture.Width != Width || Texture.Height != Height;
    public static TextureRegion Empty = new TextureRegion();
}