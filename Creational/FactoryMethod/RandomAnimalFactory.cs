namespace FactoryMethod;

public class RandomAnimalFactory : IAnimalFactory
{
    public Animal CreateAnimal()
    {
        var random = new Random();
        int value = random.Next(0, 3);

        Animal animal = value switch
        {
            0 => new Dog(),
            1 => new Cat(),
            2 => new Duck(),
            _ => null
        };

        return animal;
    }
}
