namespace State
{
    public class PendingState : BookingState
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
            Console.WriteLine("Invalid action - Pending");
        }

        public override void EnterState(BookingContext booking)
        {
            Console.WriteLine("Pending");

            int random = new Random().Next(0, 3);

            switch (random)
            {
                case 0:
                    booking.TransitionToState(new BookedState());
                    break;
                case 1:
                    booking.TransitionToState(new NewState());
                    break;
                case 2:
                    booking.TransitionToState(new ClosedState("Processing canceled"));
                    break;
                default:
                    break;
            }
        }
    }
}