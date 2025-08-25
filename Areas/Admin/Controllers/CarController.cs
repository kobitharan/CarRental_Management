using Car_Rental_Management_System.Areas.Admin.Models;
using Car_Rental_Management_System.Areas.Admin.ViewModels;
using Car_Rental_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace Car_Rental_Management_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        // GET
        public IActionResult AddCar()
        {
           

           

            return View();
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult AddCar(CarViewModels model)
        //{
        //    return View();
        //}
        public IActionResult CarList()
        {
            return View();
        }

     
      

        [HttpGet]
        public IActionResult Homedetals()
        {
            return View();
        }

        public IActionResult CarsList()
        {
           
            return View();
        }
        [HttpGet]
        public IActionResult Brand()
        {
            return View();
        }

    }
}