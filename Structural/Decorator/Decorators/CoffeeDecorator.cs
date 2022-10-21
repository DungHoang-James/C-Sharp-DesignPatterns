using Decorator.Base;

namespace Decorator.Decorators
{
    public abstract class CoffeeDecorator : ICoffee
    {
        private readonly ICoffee _coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual double Price()
        {
            return _coffee.Price();
        }
    }
}
