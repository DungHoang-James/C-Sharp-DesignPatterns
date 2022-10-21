namespace ChainOfResponsibility
{
    public class FirstHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            // some logic
            Console.WriteLine($"1 - {request.ToString()}");
            base.Handle(request);
        }
    }
}