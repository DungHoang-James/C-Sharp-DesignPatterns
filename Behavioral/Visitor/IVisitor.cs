namespace Visitor
{
    public interface IVisitor
    {
        void VisitBook(Book book);
        void VisitVinyl(Vinyl vinyl);
    }
}