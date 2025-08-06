
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Staff.Models
{
    public class LoginHistoryStaff
    {

        //    [Key]
        //    public Guid LoginnId { get; set; }
        //    [ForeignKey("UserId")]
        //    public string UserId { get; set; }
        //    public EmployeeUsers EmployeeUsers { get; set; }
        //    [Required]
        //    public DateTime LoginTime { get; set; } = DateTime.UtcNow;

        //    [Required]  
        //    public bool IsSuccessful { get; set; }

        //    [Required]
        //    public string DeviceInfo { get; set; }
        //}
        [Key]
        public Guid LoginId { get; set; }

        [Required]
        [ForeignKey(nameof(EmployeeUser))]
        public Guid UserId { get; set; }

        public EmployeeUsers EmployeeUser { get; set; }

        [Required]
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsSuccessful { get; set; }

        [Required]
        [MaxLength(512)]
        public string DeviceInfo { get; set; }
    }
}
