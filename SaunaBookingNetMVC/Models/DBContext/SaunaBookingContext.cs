namespace SaunaBookingNetMVC.Models.DBContext
{
    using Microsoft.EntityFrameworkCore;

    internal class SaunaBookingContext : DbContext
    {
        internal SaunaBookingContext(DbContextOptions<SaunaBookingContext> options) : base(options)
        {
            Users = Set<User>();
            Bookings = Set<Booking>();
        }

        internal DbSet<User> Users { get; set; } = null!;
        internal DbSet<Booking> Bookings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
