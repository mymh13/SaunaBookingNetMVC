namespace SaunaBookingNetMVC.Models.DBContext
{
    using Microsoft.EntityFrameworkCore;

    public class SaunaBookingContext : DbContext
    {
        public SaunaBookingContext(DbContextOptions<SaunaBookingContext> options) : base(options)
        {
            Users = Set<User>();
            Bookings = Set<Booking>();
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
