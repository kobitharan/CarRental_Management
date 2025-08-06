using Car_Rental_Management_System.Areas.Customer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Admin.Models
{
    public class CarViewModels
    {
        //[Key]
        //public Guid CarId { get; set; }
        //public Guid BrandId { get; set; }
        //[Required]
        //public Brand Brand { get; set; }
        //public Guid ModelId { get; set; }
        //public Model Model { get; set; }
        //[Required]
        //public string RegNo { get; set; }
        //[Required]
        //public int Year { get; set; }
        //[Required]
        //public decimal PricePerDay { get; set; }
        //[Required]
        //public string GearType { get; set; }
        //[Required]
        //public string FuelType { get; set; }
        //[Required]
        //public string Mileage { get; set; }
        //[Required]
        //public string SeatCount { get; set; }
        //[Required]
        //public string RentalCount { get; set; }
        //[Required]
        //public List<CarImage> Images { get; set; }
        //public string? Action { get; set; }
        //[Required]
        //public string Status { get; set; }
        //[Required]
        //public decimal OngoingRevenue { get; set; }
        //[Required]
        //public decimal TotalRevenue { get; set; }
        //public List<Favourite>? Favourites { get; set; }
        [Key]
        public Guid CarId { get; set; }

        [Required]
        [ForeignKey(nameof(Brand))]
        public Guid BrandId { get; set; }
       
        public Brand Brand { get; set; }

        
        [ForeignKey(nameof(Model))]
        public Guid ModelId { get; set; }

        public Model Model { get; set; }
        [Required]
        public string RegNo { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public decimal PricePerDay { get; set; }
        [Required]
        public string GearType { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required]
        public string Mileage { get; set; }
        [Required]
        public string SeatCount { get; set; }
        [Required]
        public string RentalCount { get; set; }
       
        public List<CarImage> Images { get; set; }
        public string? Action { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public decimal OngoingRevenue { get; set; }
        [Required]
        public decimal TotalRevenue { get; set; }
        public List<Favourite>? Favourites { get; set; }
    }
}
