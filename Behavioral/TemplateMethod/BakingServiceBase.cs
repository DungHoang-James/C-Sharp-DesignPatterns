namespace TemplateMethod
{
    public abstract class BakingServiceBase<T> where T : BakedFood, new()
    {
        private T item;

        public T Prepare()
        {
            item = new();

            PrepareCrust();

            AddToppings();

            Cover();

            if (item.IsRequireBaking)
            {
                Bake();
            }

            Slice();

            return item;
        }

        protected abstract void PrepareCrust();
        protected abstract void AddToppings();
        protected virtual void Cover()
        {
            // do something
        }
        protected abstract void Bake();
        protected abstract void Slice();
    }
}