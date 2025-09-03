using Car_Rental_Management_System.Areas.Customer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Admin.ViewModels
{
    public class CarViewModels
    {

        //   [Key]
        //  public Guid CarId { get; set; }


        //  public Guid BrandId { get; set; }
        //  public Guid ModelId { get; set; }

        [Required(ErrorMessage = "Please enter Registration Number")]
        public string RegNo { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public int Year { get; set; }
        [Required]
        public decimal PricePerDay { get; set; }
        [Required]
        public required string GearType { get; set; }
        [Required]
        public required string FuelType { get; set; }
        [Required]
        public required string Mileage { get; set; }
        [Required]
        public required string SeatCount { get; set; }
       // [Required]
        //public required string RentalCount { get; set; }
       
       
        public string? Action { get; set; }
        public required string Status { get; set; }
       // [Required]
      //  public decimal OngoingRevenue { get; set; }
        
        //public decimal TotalRevenue { get; set; }
       // public List<Favourite>? Favourites { get; set; }


    }
}
