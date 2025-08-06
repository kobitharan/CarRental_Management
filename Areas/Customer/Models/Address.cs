using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Customer.Models
{
    public class Address
    {
        //public Guid AddressId { get; set; }
        //public string HouseNo { get; set; }
        //public string Street1 { get; set; }
        //public string? Street2 { get; set; }
        //public string City { get; set; }
        //public int ZipCode { get; set; }
        //public string Country { get; set; }

        //public Guid UserId { get; set; }
        [Key]
        public Guid AddressId { get; set; }

        [Required]
        [MaxLength(20)]
        public string HouseNo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Street1 { get; set; }

        [MaxLength(100)]
        public string? Street2 { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [Range(10000, 999999)] // Depending on country-specific format
        public int ZipCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        [Required]
        [ForeignKey(nameof(CustomerUser))]
        public Guid CustomerId { get; set; }

        public CustomerUser CustomerUser { get; set; } // Navigation property

    }
}
