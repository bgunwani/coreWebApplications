using Microsoft.AspNetCore.Mvc;

namespace coreMvcApp.Controllers
{
    public class AccountController : Controller
    {
        // Mock Credentials
        private readonly string _username = "admin";
        private readonly string _password = "password123";

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == _username && password == _password)
            {
                // Store username to session
                HttpContext.Session.SetString("uname", username);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Invalid Credentials!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("uname");
            // HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
