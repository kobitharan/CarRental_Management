using Car_Rental_Management_System.Areas.Admin.Models;
using Car_Rental_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_Management_System.Areas.Admin.Controlers
{
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _context;


        //public IActionResult Index()
        //{
        //    return View();
        //} [HttpPost]
        public IActionResult AddCar()
        {
            //ViewBag.Brands = _context.Brands.ToList();
            //ViewBag.Models = _context.Models.ToList();
            return View();
        }
        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Car/AddCar
        [HttpPost]
        public IActionResult AddCara()
        {
            //ViewBag.Brands = _context.Brands.ToList();
            //ViewBag.Models = _context.Models.ToList();
            return View();
        }

        // POST: Admin/Car/AddCar
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult AddCar(Car car)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        car.CarId = Guid.NewGuid();
        //        _context.Cars.Add(car);
        //        _context.SaveChanges();
        //        return RedirectToAction("CarList"); // Or wherever you want to go next
        //    }

        //    ViewBag.Brands = _context.Brands.ToList();
        //    ViewBag.Models = _context.Models.ToList();
        //    return View(car);
        //}

        //// Optional: Display added cars
        //public IActionResult CarList()
        //{
        //    var cars = _context.Cars.ToList();
        //    return View(cars);
        //}
    }
    
}
