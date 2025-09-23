using BCrypt.Net;
using FoodPriceComparison.Models;
using FoodPriceComparison.Data;
using Microsoft.AspNetCore.Mvc;

namespace FoodPriceComparison.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Signup
        public IActionResult Signup()
        {
            return View();
        }

        // POST: Signup
        [HttpPost]
        public async Task<IActionResult> Signup(User user, string password)
        {
            if (user == null || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Email))
            {
                TempData["Error"] = "Please fill all fields!";
                return View(user);
            }

            if (_context.Users.Any(u => u.Email == user.Email))
            {
                TempData["Error"] = "Email already registered!";
                return View(user);
            }

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Signup successful! Please login.";
            return RedirectToAction("Login");
        }

        // GET: Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("Email", user.Email);
                return RedirectToAction("Index", "Home");
            }

            TempData["Error"] = "Invalid email or password.";
            return View();
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["Success"] = "Logged out successfully!";
            return RedirectToAction("Login");
        }
    }
}
