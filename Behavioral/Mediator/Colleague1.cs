

public class Colleague1 : Colleague
{
    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague 1 receive: {message}");
    }
}
