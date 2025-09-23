using FoodPriceComparison.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPriceComparison.Controllers
{
    public class PriceCompareController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PriceCompareController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Search Page
        public IActionResult Index()
        {
            return View();
        }

        // POST: Search Results
        [HttpPost]
        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                ViewBag.Error = "Please enter a food item to search.";
                return View("Index");
            }

            var results = await _context.PlatformPrices
                .Where(p => p.DishName.Contains(query))
                .OrderBy(p => p.Price)
                .ToListAsync();

            if (!results.Any())
            {
                ViewBag.Error = $"No results found for '{query}'.";
                return View("Index");
            }

            return View("Results", results);
        }

        [HttpGet]
        public JsonResult GetDishSuggestions(string term)
        {
            if (string.IsNullOrEmpty(term))
                return Json(new List<string>());

            var suggestions = _context.PlatformPrices
                .Where(p => p.DishName.Contains(term))
                .Select(p => p.DishName)
                .Distinct()
                .Take(5) // max 5 suggestions
                .ToList();

            return Json(suggestions);
        }


    }
}
