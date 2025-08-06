using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Customer.Models
{
    public class PhoneNumber
    {
        //[Key]
        //public Guid PhoneNumberId { get; set; }
        //public string Mobile1 { get; set; }
        //public Guid UserId { get; set; }
        [Key]
        public Guid PhoneNumberId { get; set; }

        [Required]
        [Phone]
        [MaxLength(15)] // Adjust based on format (e.g., +94xxxxxxx)
        public string Mobile1 { get; set; }

        [Required]
        [ForeignKey(nameof(CustomerUser))]
        public Guid UserId { get; set; }

        public CustomerUser CustomerUser { get; set; } // Navigation property

    }
}
