namespace Memento
{
    public class CateTaker
    {

        public IOriginator Originator { get; }
        private Stack<IMemento> history;

        public CateTaker(IOriginator origi)
        {
            Originator = origi;
            history = new();
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                Originator.Restore(history.Pop());
            }
        }
    }
}