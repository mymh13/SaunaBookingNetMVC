namespace SaunaBookingNetMVC
{
    using Microsoft.EntityFrameworkCore;
    using SaunaBookingNetMVC.Models.DBContext;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Adjust the path to use a dynamic path
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\saunaBooking.db");
            string connectionString = $"Data Source={dbPath}";
            //string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saunaBooking.db");
            //string connectionString = $"Data Source={dbPath}";


            // Register the database context
            builder.Services.AddDbContext<SaunaBookingContext>(options =>
                options.UseSqlite(connectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
