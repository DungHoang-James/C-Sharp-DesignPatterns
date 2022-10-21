

public abstract class Colleague
{
    protected Mediator mediator;

    internal void SetMediator(Mediator med)
    {
        mediator = med;
    }

    public virtual void Send(string message)
    {
        mediator.Send(message, this);
    }

    public abstract void HandleNotification(string message);
}
