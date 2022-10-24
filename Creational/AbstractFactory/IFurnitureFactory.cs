namespace AbstractFactory;

public interface IFurnitureFactory
{
    Table CreateTable();
    Chair CreateChair();
}
