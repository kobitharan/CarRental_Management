using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Car_Rental_Management_System.Areas.Customer.Models
{
    public class Payment
    {
        //public Guid PaymentId { get; set; }
        //public DateTime? CreatedDate { get; set; } = default(DateTime?);
        //public string CustomerId { get; set; }
        //public CustomerUser CustomerUser { get; set; }
        ////public Guid BookingId { get; set; }
        ////public Booking Booking { get; set; }
        //public RentalRequest RentalRequest { get; set; }

        //public Guid RentalRequestId { get; set; }
        //public double Amount { get; set; }
        //public string PaymentType { get; set; }
        [Key]
        public Guid PaymentId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Required]
        [ForeignKey(nameof(CustomerUser))]
        public Guid CustomerId { get; set; }

        public CustomerUser CustomerUser { get; set; }


        [Required]
        [ForeignKey(nameof(RentalRequest))]
        public Guid RentalRequestId { get; set; }

        public RentalRequest RentalRequest { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Amount { get; set; }

        [Required]
        [MaxLength(50)]
        public string PaymentType { get; set; }


    }
}
