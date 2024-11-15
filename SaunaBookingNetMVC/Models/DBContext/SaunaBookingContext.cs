namespace SaunaBookingNetMVC.Models.DBContext
{
    using Microsoft.EntityFrameworkCore;

    internal class SaunaBookingContext : DbContext
    {
        internal SaunaBookingContext(DbContextOptions<SaunaBookingContext> options) : base(options)
        {
        }

        internal DbSet<User> Users { get; set; }
        internal DbSet<Booking> Bookings { get; set; }

    }
}
