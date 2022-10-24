namespace Composites;

public abstract class Component
{
    public string Name { get; }

    public Component(string name)
    {
        Name = name;
    }

    public abstract void PrimaryOperation(int depth);
}
