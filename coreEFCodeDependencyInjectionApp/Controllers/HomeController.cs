using coreEFCodeDependencyInjectionApp.Models;
using coreEFCodeDependencyInjectionApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coreEFCodeDependencyInjectionApp.Controllers
{
    public class HomeController : Controller
    {

        //private MessageService messageService = new MessageService();

        private IMessageService _messageService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _messageService.GetMessage();
            return View();
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
