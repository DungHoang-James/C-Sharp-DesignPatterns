namespace Decorator.Base
{
    public class Coffee : ICoffee
    {
        private readonly double _price = 5;

        public double Price()
        {
            return _price;
        }
    }
}
