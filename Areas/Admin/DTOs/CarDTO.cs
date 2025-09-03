using System.ComponentModel.DataAnnotations;

namespace Car_Rental_Management_System.Areas.Admin.DTOs
{
    public class CarDTO
    {
        //public string Name { get; set; } = "";
        //public decimal Price { get; set; }

        public int Year { get; set; }

        public decimal PricePerDay { get; set; }

        public required string GearType { get; set; }

        public required string FuelType { get; set; }

        public required string Mileage { get; set; }

        public required string SeatCount { get; set; }

        public required string RentalCount { get; set; }
        public required string RegNo { get; set; }


        public required string? Action { get; set; }

        public required string Status { get; set; }

        public decimal OngoingRevenue { get; set; }

        public decimal TotalRevenue { get; set; }
    }
}
