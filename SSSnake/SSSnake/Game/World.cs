#nullable enable
using System;
using System.Drawing;

namespace SSSnake;

public delegate Tile TileProv(int x, int y);
public class World
{
    public int Width { get; private set; }
    public int Height { get; private set; }
    public Tile[,] Tiles { get; private set; } = new Tile[0, 0];

    public void CreateTiles(int width, int height)
    {
        Width = width;
        Height = height;
        Tiles = new Tile[width, height];
        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                Tiles[x, y] = new Tile
                {
                    X = x,
                    Y = y
                };
            }
        }
    }

    public void Fill(TileProv filler)
    {
        for (var x = 0; x < Width; x++)
        {
            for (var y = 0; y < Height; y++)
            {
                Tiles[x, y] = filler(x, y);
            }
        }
    }


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