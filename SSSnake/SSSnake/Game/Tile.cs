#nullable enable
using System.Numerics;
using SSSnake.Types;

namespace SSSnake;

public class Tile
{
    public int X, Y;
    public Block? Block;

    public float DrawX => X * Vars.TileSize;
    public float DrawY => Y * Vars.TileSize;
    public Vector2 DrawXy => new(X * Vars.TileSize, Y * Vars.TileSize);

    public void Draw()
    {
        Block?.Draw(this);
    }
}