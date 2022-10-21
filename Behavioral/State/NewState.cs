namespace State
{
    public class NewState : BookingState
    {
        public override void Cancel(BookingContext booking)
        {
            booking.TransitionToState(new ClosedState("Booking canceled"));
        }

        public override void DatePassed(BookingContext booking)
        {
            booking.TransitionToState(new ClosedState("Booking expired"));
        }

        public override void EnterDetail(BookingContext booking, string attendee, int ticketCount)
        {
            booking.Attendee = attendee;
            booking.TicketCount = ticketCount;
            booking.TransitionToState(new PendingState());
        }

        public override void EnterState(BookingContext booking)
        {
            booking.BookingId = new Random().Next();
            Console.WriteLine("New");
        }
    }
}