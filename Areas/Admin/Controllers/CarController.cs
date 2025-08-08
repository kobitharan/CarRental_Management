using Car_Rental_Management_System.Areas.Admin.Models;
using Car_Rental_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_Management_System.Areas.Admin.Controllers // ✅ spelling fix
{
    [Area("Admin")] // ✅ Important for routing
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Car/AddCar
        [HttpGet]
        public IActionResult AddCar()
        {
           
            return View();
        }

        // POST: Admin/Car/AddCar
       
      

        // GET: Admin/Car/CarList
       
    }
}
