namespace Flyweight;

public class DrinkFactory
{
    private Dictionary<string, IDrinkFlyweight> _drinkCache;

    public DrinkFactory()
    {
        _drinkCache = new();
    }

    public IDrinkFlyweight CreateGiveaway()
    {
        return new DrinkGiveaway();
    }

    public IDrinkFlyweight GetDrink(string drinkKey)
    {
        if (_drinkCache.ContainsKey(drinkKey))
        {
            return _drinkCache[drinkKey];
        }
        else
        {
            IDrinkFlyweight drink;

            switch (drinkKey)
            {
                case "Espresso":
                    drink = new Espresso();
                    _drinkCache.Add("Espresso", drink);
                    return drink;
                case "BananaSmoothie":
                    drink = new BananaSmoothie();
                    _drinkCache.Add("BananaSmoothie", drink);
                    return drink;
                default:
                    return null;
            }
        }
    }
}
