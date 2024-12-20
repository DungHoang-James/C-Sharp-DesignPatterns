namespace State
{
    public abstract class BookingState
    {
        public abstract void EnterState(BookingContext booking);
        public abstract void Cancel(BookingContext booking);
        public abstract void DatePassed(BookingContext booking);
        public abstract void EnterDetail(BookingContext booking, string attendee, int ticketCount);
    }
}