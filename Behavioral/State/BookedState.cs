namespace State
{
    public class BookedState : BookingState
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
            Console.WriteLine("Invalid action - Booked");
        }

        public override void EnterState(BookingContext booking)
        {
            Console.WriteLine("Booked");
        }
    }
}