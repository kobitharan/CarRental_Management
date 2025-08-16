using Microsoft.AspNetCore.Mvc;

namespace Car_Rental_Management_System.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Homedetals()
        {
            return View();
        }

       
    }
}
