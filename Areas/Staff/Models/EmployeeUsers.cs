using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Staff.Models
{
    public class EmployeeUsers
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string PasswordHash { get; set; }
        [ForeignKey("EmployeeId")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

       
    }
}
