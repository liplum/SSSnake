using System.IO;
using SSSnake.State;

namespace SSSnake;

public static class Vars
{
    public static SnakeGame Game;
    public static DirectoryInfo AssetDir = new("Assets");
    public static float TileSize = 8;
    public static World World;
    public static GameState State = GameState.Load;
}