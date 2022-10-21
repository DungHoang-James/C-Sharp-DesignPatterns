
using Decorator.Base;
using Decorator.Decorators;

Console.WriteLine("Coffee with milk and ice");

Coffee coffee = new Coffee();
Milk milk = new(coffee);
CoffeeDecorator coffeeDecorator = new Ice(milk);

Console.WriteLine($"Price: {coffeeDecorator.Price()}");
