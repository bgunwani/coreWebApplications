using Microsoft.AspNetCore.Mvc;

namespace coreBasicApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Message()
        {
            return View();
        }
        public ViewResult Privacy()
        {
            return View();
        }
        public ViewResult list()
        {
            return View();
        }
    }   
}
