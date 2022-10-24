namespace Flyweight;

public class BananaSmoothie : IDrinkFlyweight
{
    public string Name { get; }
    private IEnumerable<string> _ingredients;

    public BananaSmoothie()
    {
        Name = "Banana Smoothie";
        _ingredients = new List<string>()
        {
            "Banana",
            "Whole Milk",
            "Vanilla Extract"
        };
    }

    public void Serve(string size)
    {
        Console.WriteLine(size);
    }
}
