using System.ComponentModel.DataAnnotations;

namespace Car_Rental_Management_System.Areas.Admin.Models
{
    public class AdminUsers
    {
        [Key]
        public Guid AdminId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string NicNo { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address format")]
        public string Email { get; set; }

        [Required]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Image is required")]
        public string ImagePath { get; set; }
    }
}
