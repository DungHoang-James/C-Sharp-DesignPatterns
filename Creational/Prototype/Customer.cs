namespace Prototype
{
    public class Customer : AbstractPrototype
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> FavoriteProduct { get; set; }

        public override AbstractPrototype ShallowCopy()
        {
            return (AbstractPrototype)this.MemberwiseClone();
        }

        public override AbstractPrototype DeepCopy()
        {
            Customer customer = (Customer)this.MemberwiseClone();

            customer.FavoriteProduct = FavoriteProduct.ToList();

            return customer;
        }
    }
}