namespace Flyweight;

public class DrinkGiveaway : IDrinkFlyweight
{
    public string Name
    {
        get
        {
            return _randomDrink.Name;
        }
    }

    private List<IDrinkFlyweight> _eligibleDrinks;

    private IDrinkFlyweight _randomDrink;
    private string _size;

    public DrinkGiveaway()
    {
        _eligibleDrinks = new()
        {
            new BananaSmoothie(),
            new Espresso()
        };

        Random random = new Random();
        _randomDrink = _eligibleDrinks[random.Next(0, 2)];
    }

    public void Serve(string size)
    {
        _size = size;
        Console.WriteLine(size);
    }
}
