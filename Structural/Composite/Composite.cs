namespace Composites;

public class Composite : Component
{
    private readonly List<Component> _children;

    public Composite(string name) : base(name)
    {
        _children = new();
    }

    public void Add(Component c)
    {
        _children.Add(c);
    }

    public override void PrimaryOperation(int depth)
    {
        Console.WriteLine(new String('-', depth) + this.Name);
        foreach (var component in _children)
        {
            component.PrimaryOperation(depth + 2);
        }
    }

    public void Remove(Component c)
    {
        _children.Remove(c);
    }
}
