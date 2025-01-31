using coreMiddlewareApp.Filters;
using coreMiddlewareApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coreMiddlewareApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [RequestLoggingFilter]
        public IActionResult Index()
        {
            return View();
        }

        [RequestLoggingFilter]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TriggerError()
        {
            throw new Exception("THis is a test exception to check global error handling!");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
