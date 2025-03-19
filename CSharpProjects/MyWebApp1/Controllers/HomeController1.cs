using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        // Display the login page
        public IActionResult Login()
        {
            return View();
        }

        // Handle the login form submission
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                // Simulate a simple login check
                if (user.Username == "admin" && user.Password == "password")
                {
                    return RedirectToAction("HomePage");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");
                }
            }
            return View(user);
        }

        // Display the home page after successful login
        public IActionResult HomePage()
        {
            return View();
        }
    }
}
