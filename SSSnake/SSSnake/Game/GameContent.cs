namespace SSSnake;

public class GameContent
{
    public readonly string Name;

    public GameContent(string name)
    {
        Name = name;
    }

    public virtual void LoadResource()
    {
    }

    public virtual void Init()
    {
    }
}