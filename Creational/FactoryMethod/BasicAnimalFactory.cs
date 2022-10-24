namespace FactoryMethod;

public class BasicAnimalFactory : IAnimalFactory
{
    int index = 0;

    public Animal CreateAnimal()
    {
        if (index == 0)
        {
            index++;
            return new Dog();
        }
        else if (index == 1)
        {
            index++;
            return new Cat();
        }
        else
        {
            index = 0;
            return new Duck();
        }
    }
}
