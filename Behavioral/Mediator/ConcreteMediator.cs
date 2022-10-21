
public class ConcreteMediator : Mediator
{
    private List<Colleague> colleagues = new();

    public void Register(Colleague colleague)
    {
        colleague.SetMediator(this);
        this.colleagues.Add(colleague);
    }

    public override void Send(string message, Colleague colleague)
    {
        this.colleagues.Where(c => c != colleague)
        .ToList()
        .ForEach(c => c.HandleNotification(message));
    }

    public T CreateColleague<T>() where T : Colleague, new()
    {
        var c = new T();
        c.SetMediator(this);
        this.colleagues.Add(c);
        return c;
    }
}
