namespace SaunaBookingNetMVC.Models
{
    internal class Booking
    {
        internal int Id { get; set; }
        internal DateTime BookingDate { get; set; }
        internal DateTime StartTime { get; set; }
        internal DateTime Endtime { get; set; }
        internal string Status { get; set; } // could be good to know if the booking is active or not
        internal int UserId { get; set; }
    }
}
