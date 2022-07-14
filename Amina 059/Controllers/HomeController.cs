using Amina_059.Data;
using Amina_059.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Amina_059.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _context=context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult about()
        {
            return View();
        }

        public IActionResult contactus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult form(customer_contact s)
        {
            _context.customer_contact.Add(s);
            _context.SaveChanges();
            ViewBag.message = "SUCCESSFULL";
            return View("index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}