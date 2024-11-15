namespace SaunaBookingNetMVC.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Endtime { get; set; }
        public string? Status { get; set; } // could be good to know if the booking is active or not
        public int UserId { get; set; }

        // Navigation Property
        public User? User { get; set; }
    }
}
