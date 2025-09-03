using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Admin.Models
{
    public class CarImage
    {
        //[Key]
        //public Guid Id { get; set; }
        //[Required]
        //public string ImagePath { get; set; }
        //public Guid CarId { get; set; }
        //[ForeignKey("CarId")]
        //public Car Car { get; set; }

        [Key]
        public Guid ImageId { get; set; }

        [Required]
        [MaxLength(255)]
        public required string ImagePath { get; set; }

        [ForeignKey(nameof(CarId))]

        [Required]
        public Guid CarId { get; set; }

       
        public required Car Car { get; set; }
    }
}
