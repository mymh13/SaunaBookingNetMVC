namespace SaunaBookingNetMVC.Models.DBContext
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    using System.IO;

    public class SaunaBookingContextFactory : IDesignTimeDbContextFactory<SaunaBookingContext>
    {
        internal SaunaBookingContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<SaunaBookingContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            
            //string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "saunaBooking.db");
            //var connectionString = $"Data Source={dbPath}";

            optionsBuilder.UseSqlite(connectionString);

            return new SaunaBookingContext(optionsBuilder.Options);
        }
    }
}
