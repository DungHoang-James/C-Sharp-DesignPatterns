namespace TemplateMethod
{
    public class PieBakingService : BakingServiceBase<Pie>
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