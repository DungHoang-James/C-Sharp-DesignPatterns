namespace TemplateMethod
{
    public class PizzaBakingService : BakingServiceBase<Pizza>
    {
        protected override void AddToppings()
        {
            throw new NotImplementedException();
        }

        protected override void Bake()
        {
            throw new NotImplementedException();
        }

        protected override void PrepareCrust()
        {
            throw new NotImplementedException();
        }

        protected override void Slice()
        {
            throw new NotImplementedException();
        }
    }
}