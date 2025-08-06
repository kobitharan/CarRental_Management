using System.ComponentModel.DataAnnotations;

namespace Car_Rental_Management_System.Areas.Customer.Models
{
    public class CustomerUser
    {
        //public Guid UId { get; set; }

        //public string? Image { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string NIC { get; set; }

        //public string? Token { get; set; }
        //public string? Licence { get; set; }

        //public string Email { get; set; }

        //public List<Address>? Addresses { get; set; }
        //public List<PhoneNumber>? PhoneNumbers { get; set; }

        //public string Password { get; set; }


        //public string? RefreshToken { get; set; }
        //public DateTime? RefreshTokenExpiry { get; set; }
        //public string? ForgetPasswordToken { get; set; }
        //public DateTime? ForgetPasswordTokenExpiry { get; set; }

        //public string? status { get; set; }
        //public string? Notes { get; set; }
        //public decimal OngoingRevenue { get; set; }
        //public decimal TotalRevenue { get; set; }
        //public List<Favourite>? Favourites { get; set; }

        [Key]
        public Guid CustomerId { get; set; }

        [MaxLength(255)]
        public string? Image { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string NIC { get; set; }

        [MaxLength(512)]
        public string? Token { get; set; }//code

        [MaxLength(255)]
        public string? Licence { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public List<Address>? Addresses { get; set; }
        public List<PhoneNumber>? PhoneNumbers { get; set; }
        public List<Favourite>? Favourites { get; set; }
        public List<Payment>? Payments { get; set; }

      
 

        [MaxLength(50)]
        public string? Status { get; set; }

        [MaxLength(1000)]
        public string? Notes { get; set; }

        [Range(0, double.MaxValue)]
        public decimal OngoingRevenue { get; set; }

        [Range(0, double.MaxValue)]
        public decimal TotalRevenue { get; set; }


    }
}
