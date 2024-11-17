namespace SaunaBookingNetMVC.Models.DBContext
{
    using Microsoft.EntityFrameworkCore;

    // Keep the class public for accessibility during migrations
    public class SaunaBookingContext : DbContext
    {
        // Make the constructor internal to restrict instantiation
        internal SaunaBookingContext(DbContextOptions<SaunaBookingContext> options) : base(options)
        {
            Users = Set<User>();
            Bookings = Set<Booking>();
        }

        // DbSet properties need to be public if the class is public
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
