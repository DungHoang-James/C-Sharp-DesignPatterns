namespace Visitor
{
    public class ObjectStructure
    {
        private List<IVisitableElement> visitableElements;

        public ObjectStructure(List<IVisitableElement> item)
        {
            visitableElements = item;
        }

        public void ApplyVisitor(IVisitor visitor)
        {
            foreach (var item in visitableElements)
            {
                item.Accept(visitor);
            }
        }
    }
}