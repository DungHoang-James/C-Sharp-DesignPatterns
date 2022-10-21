namespace ChainOfResponsibility
{
    public abstract class Handler<T> : IHandler<T> where T : class
    {
        private IHandler<T> _next;

        public IHandler<T> SetNext(IHandler<T> next)
        {
            _next = next;

            return _next;
        }

        public virtual void Handle(T request)
        {
            _next?.Handle(request);
        }
    }
}