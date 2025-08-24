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
            var model = new BrandViewModels();

            // Database-லிருந்து Brand-களை எடுக்க
            var brands = _context.Brand.ToList();

            if (brands.Any()) // Data இருக்கா என்று check
            {
                model.Brands = brands
                    .Select(b => new SelectListItem
                    {
                        Value = b.Id.ToString(), // Dropdown value = Brand Id
                        Text = b.Name            // Dropdown text = Brand Name
                    })
                    .ToList();
            }
            else
            {  // ethuu  maththaanum 
                return View();
            }

            return View(model);
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