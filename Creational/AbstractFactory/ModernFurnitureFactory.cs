namespace AbstractFactory;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public Chair CreateChair()
    {
        return new ModernChair();
    }

    public Table CreateTable()
    {
        return new ModernTable();
    }
}