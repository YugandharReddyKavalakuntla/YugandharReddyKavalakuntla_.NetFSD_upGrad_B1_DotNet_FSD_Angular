using Microsoft.AspNetCore.Mvc;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>();

        // Register GET
        public IActionResult Register()
        {
            return View();
        }

        // Register POST
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = users.Count + 1;
                users.Add(user);
                return RedirectToAction("Login");
            }
            return View(user);
        }

        // Login GET
        public IActionResult Login()
        {
            return View();
        }

        // Login POST
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("UserEmail", user.Email);
                return RedirectToAction("Profile");
            }

            ViewBag.Error = "Invalid Login";
            return View();
        }

        // Profile
        public IActionResult Profile()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
                return RedirectToAction("Login");

            var user = users.FirstOrDefault(x => x.Email == email);

            var vm = new UserViewModel
            {
                Name = user.Name,
                Email = user.Email
            };

            return View(vm);
        }

        // Edit GET
        public IActionResult Edit()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
                return RedirectToAction("Login");

            var user = users.FirstOrDefault(x => x.Email == email);
            return View(user);
        }

        // Edit POST
        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            var user = users.FirstOrDefault(x => x.Email == updatedUser.Email);

            if (user != null)
            {
                user.Name = updatedUser.Name;
            }

            return RedirectToAction("Profile");
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}