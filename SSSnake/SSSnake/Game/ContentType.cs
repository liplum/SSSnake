namespace SSSnake;

public class Content
{
    public readonly string Name;

    public Content(string name)
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