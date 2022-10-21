namespace State
{
    public class ClosedState : BookingState
    {
        private string reasonClosed;

        public ClosedState(string reason)
        {
            reasonClosed = reason;
        }

        public override void Cancel(BookingContext booking)
        {
            Console.WriteLine("Invalid action - Closed");
        }

        public override void DatePassed(BookingContext booking)
        {
            Console.WriteLine("Invalid action - Closed");
        }

        public override void EnterDetail(BookingContext booking, string attendee, int ticketCount)
        {
            Console.WriteLine("Invalid action - Closed");
        }

        public override void EnterState(BookingContext booking)
        {
            Console.WriteLine($"Closed - reason: {reasonClosed}");
        }
    }
}