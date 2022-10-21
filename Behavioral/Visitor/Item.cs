namespace Visitor
{
    public class Item
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public Item(int id, double price)
        {
            Id = id;
            Price = price;
        }

        public double GetDiscount(double percentage)
        {
            return Math.Round(Price * percentage, 2);
        }
    }
}