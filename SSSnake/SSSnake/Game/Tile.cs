#nullable enable
using SSSnake.Types;

namespace SSSnake;

public class Tile
{
    public int X, Y;
    public Block? Block;

    public void Draw()
    {
        Block?.Draw(this);
    }
}