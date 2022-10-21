using Decorator.Base;

namespace Decorator.Decorators
{
    public class Ice : CoffeeDecorator
    {
        private readonly double _price = 0.5;

        public Ice(ICoffee coffee) : base(coffee)
        {
        }

        public override double Price()
        {
            return _price + base.Price();
        }
    }
}
