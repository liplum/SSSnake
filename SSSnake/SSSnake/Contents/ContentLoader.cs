using SSSnake.Types;

namespace SSSnake.Contents;

public static class ContentLoader
{
    public static void Load()
    {
        Snakes.Load();
        Foods.Load();
        Blocks.Load();
    }
}

public static class Snakes
{
    public static void Load()
    {
        var whiteSnake = new SnakeType("white");
    }
}

public static class Foods
{
    public static void Load()
    {
        var apple = new Food("apple");
    }
}

public static class Blocks
{
    public static Block Test;
    public static Block Error;

    public static void Load()
    {
        Test = new BackgroundBlock("test-block");
        Error = new BackgroundBlock("Nameless");
    }
}