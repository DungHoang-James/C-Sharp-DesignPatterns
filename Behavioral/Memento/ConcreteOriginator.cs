namespace Memento
{
    public class ConcreteOriginator : IOriginator
    {
        private OriginatorEnum state;

        public IMemento CreateMemento()
        {
            return new ConcreteMemento(state);
        }

        public void Restore(IMemento memento)
        {
            state = memento.State;
        }
    }
}