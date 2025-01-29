using Microsoft.AspNetCore.Mvc;

namespace coreMvcApp.Controllers
{
    public class AccountController : Controller
    {
        // Mock Credentials
        private readonly string _username = "admin";
        private readonly string _password = "password123";

        private readonly Dictionary<string, (string Password, string Role)> users = new()
        {
            { "king", ("password123", "Admin") },
            { "kochhar", ("password123", "User") }
        };

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password, bool rememberMe)
        {
            //if (username == _username && password == _password)
            //{
            //    // Store username to session
            //    HttpContext.Session.SetString("uname", username);
            //    return RedirectToAction("Index", "Home");
            //}
            //ViewBag.Error = "Invalid Credentials!";
            //return View();

            if(users.ContainsKey(username) && users[username].Password == password)
            {
                HttpContext.Session.SetString("UserSession", username);
                HttpContext.Session.SetString("UserRole", users[username].Role);

                if (rememberMe)
                {
                    Response.Cookies.Append("UserSession", username, new CookieOptions
                    {
                        Expires = DateTime.UtcNow.AddDays(7),
                        HttpOnly = true
                    });
                    Response.Cookies.Append("UserRole", users[username].Role, new CookieOptions
                    {
                        Expires = DateTime.UtcNow.AddDays(7),
                        HttpOnly = true
                    });
                }
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Invalid Credentials!";
            return View();
        }

        public IActionResult Logout()
        {
            //HttpContext.Session.Remove("uname");
            HttpContext.Session.Clear();
            Response.Cookies.Delete("UserSession");
            Response.Cookies.Delete("UserRole");
            return RedirectToAction("Login");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
