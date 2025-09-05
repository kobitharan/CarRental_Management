using Microsoft.AspNetCore.Mvc;
using Car_Rental_Management_System.Models; 


namespace Car_Rental_Management_System.Areas.Customer.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(UserRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Your registration logic here

            return RedirectToAction("Index", "Home"); // Or wherever you want
        }
    }
}

