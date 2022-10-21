namespace ChainOfResponsibility
{
    public class SecondHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            // some logic
            Console.WriteLine($"2 - {request.ToString()}");
            base.Handle(request);
        }
    }
}