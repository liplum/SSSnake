using SSSnake.Types;

namespace SSSnake.Contents;

public static class ContentLoader
{
    public static Block TestBlock;
    public static void Load()
    {
        LoadFood();
        LoadSnake();
    }

    private static void LoadSnake()
    {
        var whiteSnake = new SnakeType("white");
    }

    private static void LoadFood()
    {
        var apple = new Food("apple");
    }

    private static void LoadBlock()
    {
        TestBlock = new Block("test-block");
    }
}