using Decorator.Base;

namespace Decorator.Decorators
{
    public class Milk : CoffeeDecorator
    {
        private readonly double _price = 2;

        public Milk(ICoffee coffee) : base(coffee)
        {
        }

        public override double Price()
        {
            return _price + base.Price();
        }
    }
}
