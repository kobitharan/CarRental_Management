using Car_Rental_Management_System.Areas.Admin.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Customer.Models
{
    public class RentalRequest
    {
        //public Guid c { get; set; }
        //public DateTime RequestDate { get; set; } = DateTime.Today;
        //public Guid CarId { get; set; }
        //public Guid UserId { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
        //public int Duration { get; set; }
        //public decimal TotalPrice { get; set; }
        //public string Action { get; set; }
        //public string Status { get; set; }
        //public DateTime ReturnedDate { get; set; }
        //public int OverDueDuration { get; set; }
        //public decimal OverDueAmount { get; set; }

        //public Car Car { get; set; }
        //public User User { get; set; }
        [Key]
        public Guid RentalRequestId { get; set; }

        [Required]
        public DateTime RequestDate { get; set; } = DateTime.Today;

        [Required]
        [ForeignKey(nameof(Car))]
        public Guid CarId { get; set; }

        [Required]
        [ForeignKey(nameof(CustomerUser))]
        public Guid CustomerId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int Duration { get; set; } // Ideally, this could be calculated

        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalPrice { get; set; }

        [Required]
        [MaxLength(50)]
        public string Action { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        public DateTime? ReturnedDate { get; set; }

        public int OverDueDuration { get; set; }

        [Range(0, double.MaxValue)]
        public decimal OverDueAmount { get; set; }

        public CarViewModels Car { get; set; }
        public CustomerUser CustomerUser { get; set; }

    }
}
