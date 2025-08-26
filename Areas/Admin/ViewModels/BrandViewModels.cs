using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental_Management_System.Areas.Admin.ViewModels
{
    public class BrandViewModels
    {
        [Required(ErrorMessage = "Please select a brand")]
        public int BrandId { get; set; }   // Selected BrandId

        public String Name { get; set; }


        public List<SelectListItem> Brands { get; set; }
    }
}
