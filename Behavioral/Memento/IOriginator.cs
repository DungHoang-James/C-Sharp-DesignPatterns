namespace Memento
{
    public interface IOriginator
    {
        IMemento CreateMemento();
        void Restore(IMemento memento);
    }
}