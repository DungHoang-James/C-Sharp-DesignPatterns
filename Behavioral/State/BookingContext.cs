namespace State
{
    public class BookingContext
    {
        public string Attendee { get; set; }
        public int TicketCount { get; set; }
        public int BookingId { get; set; }

        private BookingState currentState;

        public BookingContext()
        {
            TransitionToState(new NewState());
        }

        public void TransitionToState(BookingState state)
        {
            currentState = state;
            currentState.EnterState(this);
        }

        public void SubmitDetail(string attendee, int ticketCount)
        {
            currentState.EnterDetail(this, attendee, ticketCount);
        }

        public void Cancel()
        {
            currentState.Cancel(this);
        }

        public void DatePassed()
        {
            currentState.DatePassed(this);
        }
    }
}