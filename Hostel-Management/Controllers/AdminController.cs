using Microsoft.AspNetCore.Mvc;
using Hostel_Management.Models;
using Microsoft.AspNetCore.Http;

namespace Hostel_Management.Controllers
{
    public class AdminController : Controller
    {
        // GET: Display Login Page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Handle Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AdminLoginViewModel model)
        {
            // Hardcoded admin credentials
            string adminEmail = "jay@gmail.com";
            string adminPassword = "1234";

            if (ModelState.IsValid)
            {
                // Check if the entered email and password match the hardcoded credentials
                if (model.Email == adminEmail && model.Password == adminPassword)
                {
                    HttpContext.Session.SetString("AdminEmail", model.Email);
                    // Successful login, redirect to Admin Dashboard
                    return RedirectToAction("Index");
                }
                else
                {
                    // Invalid credentials, display an error message
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }

            // Return the view with validation errors
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            // Clear the session
            HttpContext.Session.Remove("AdminEmail");
            return RedirectToAction("Login");
        }


        // Admin Dashboard
        public IActionResult Index()
        {
            return View();
        }
    }

}
