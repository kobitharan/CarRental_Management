using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Staff.Models
{
    public class StaffAddress
    {
        [Key]
        public Guid AddressId { get; set; }
        [Required]
        public string HouseNo { get; set; }
        [Required]

        public string Street1 { get; set; }
        [Required]
        public string? Street2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string Country { get; set; }
        [ForeignKey("EmployeeId")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
