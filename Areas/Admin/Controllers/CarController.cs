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

        public IActionResult AddCar()
        {
           

            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddCar(CarViewModels car)
        {

            //if (!ModelState.IsValid)
            //    return View(car);
            //_context.Car.Add(car);
            //_context.SaveChanges();
            //var dto = new DTOs.CarDTO
            //{
            //    Year = car.Year,
            //    RegNo = car.RegNo,
            //    PricePerDay = car.PricePerDay,
            //    GearType = car.GearType,
            //    FuelType = car.FuelType,
            //    Mileage = car.Mileage,
            //    SeatCount = car.SeatCount,
            //    RentalCount = "0",
            //    Action = "Active",
            //    Status = "Active",
            //};
            //TempData["Success"] = "Car added successfully!";
            //  return RedirectToAction("Index");
            return View();
        }

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