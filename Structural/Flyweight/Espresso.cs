namespace Flyweight;

public class Espresso : IDrinkFlyweight
{
    public string Name { get; }
    private IEnumerable<string> _ingredients;

    public Espresso()
    {
        Name = "Espresso";
        _ingredients = new List<string>()
        {
            "Coffe Beans",
            "Hot Water"
        };
    }

    public void Serve(string size)
    {
        Console.WriteLine(size);
    }
}
