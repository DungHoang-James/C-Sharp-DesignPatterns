namespace Memento
{
    public class ConcreteMemento : IMemento
    {
        public OriginatorEnum State { get; }

        public ConcreteMemento(OriginatorEnum state)
        {
            State = state;
        }
    }
}