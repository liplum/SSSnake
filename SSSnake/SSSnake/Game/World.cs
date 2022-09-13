#nullable enable
using System.Drawing;

namespace SSSnake;

public class World
{
    public int Width, Height;
    public Tile[,] Tiles;

    public Tile? GetTileAt(int x, int y)
    {
        if (x < 0 || x >= Width) return null;
        if (y < 0 || y >= Height) return null;
        return Tiles[x, y];
    }

    public Tile? GetTileAt(Point p) => GetTileAt(p.X, p.Y);

    public void Draw()
    {
        for (var x = 0; x < Width; x++)
        {
            for (var y = 0; y < Height; y++)
            {
                Tiles[x, y].Draw();
            }
        }
    }
}