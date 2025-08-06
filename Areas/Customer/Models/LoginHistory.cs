using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Customer.Models
{
    public class LoginHistory
    {
        //[Key]
        //public Guid LoginId { get; set; }
        //[ForeignKe]
        //public string CustomerId { get; set; }
        //public DateTime LoginTime { get; set; } = DateTime.UtcNow;
        //public bool IsSuccessful { get; set; }
        //public string DeviceInfo { get; set; }
        [Key]
        public Guid LoginId { get; set; }

        [Required]
        [ForeignKey(nameof(CustomerUser))]
        public Guid CustomerId { get; set; }

        public CustomerUser CustomerUser { get; set; }  // Navigation property

        [Required]
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsSuccessful { get; set; }

        [Required]
        [MaxLength(512)]
        public string DeviceInfo { get; set; }
    }
}
