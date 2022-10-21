namespace State
{
    public class Booking
    {
        public string Attendee { get; set; }
        public int TicketCount { get; set; }
        public int BookingId { get; set; }

        public void SubmitDetail(string attendee, int ticketCount)
        {
        }

        public void Cancel()
        {
        }

        public void DatePassed(){}
    }
}