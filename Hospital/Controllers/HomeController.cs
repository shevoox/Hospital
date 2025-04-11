using Hospital.Data;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context = new();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string search, int page = 1)
        {
            var doctors = _context.Doctors.AsQueryable();

            if (search is not null)
            {
                doctors = doctors.Where(d => d.Name.Contains(search));
            }


            var totalCount = doctors.Count();


            doctors = doctors.Skip(5 * (page - 1)).Take(5);


            ViewBag.totalCountOfProduct = Math.Ceiling(totalCount / (decimal)5.0);


            return View(doctors.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
