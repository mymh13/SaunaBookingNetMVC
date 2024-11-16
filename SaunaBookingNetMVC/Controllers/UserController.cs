namespace SaunaBookingNetMVC.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SaunaBookingNetMVC.Models;
    using SaunaBookingNetMVC.Models.DBContext;

    public class UserController : Controller
    {
        private readonly SaunaBookingContext _context;

        internal UserController(SaunaBookingContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
