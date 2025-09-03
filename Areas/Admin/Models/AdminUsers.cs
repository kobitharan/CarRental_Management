using System.ComponentModel.DataAnnotations;

namespace Car_Rental_Management_System.Areas.Admin.Models
{
    public class AdminUsers
    {
        [Key]
        public Guid AdminId { get; set; }
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public required string NicNo { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address format")]
        public required string Email { get; set; }

        [Required]
        public required string Mobile { get; set; }
        [Required(ErrorMessage = "Image is required")]
        public required string ImagePath { get; set; }
    }
}
