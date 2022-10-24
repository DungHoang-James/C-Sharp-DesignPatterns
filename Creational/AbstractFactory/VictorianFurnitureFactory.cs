namespace AbstractFactory;

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public Chair CreateChair()
    {
        return new VictorianChair();
    }

    public Table CreateTable()
    {
        return new VictorianTable();
    }
}
