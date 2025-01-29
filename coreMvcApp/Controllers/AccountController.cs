using Microsoft.AspNetCore.Mvc;

namespace coreMvcApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
