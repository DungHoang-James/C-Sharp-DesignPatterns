namespace Strategy
{
    public class Ticket
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public IPromoteStrategy PromoteStrategy { get; set; }

        public Ticket()
        {

        }

        public Ticket(IPromoteStrategy strategy)
        {
            PromoteStrategy = strategy;
        }

        public double GetPromotedPrice()
        {
            return PromoteStrategy.DoDiscount(Price);
        }
    }
}