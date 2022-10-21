

public class Colleague2 : Colleague
{
    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague 2 receive: {message}");
    }
}