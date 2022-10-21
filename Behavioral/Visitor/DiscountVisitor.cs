namespace Visitor
{
    public class DiscountVisitor : IVisitor
    {
        public void VisitBook(Book book)
        {
            Console.WriteLine("Visit Book");
        }

        public void VisitVinyl(Vinyl vinyl)
        {
            Console.WriteLine("Visit Vinyl");
        }
    }
}