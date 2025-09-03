using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Admin.Models
{
    public class Model
    {
    //    [Key]
    //    public Guid Id { get; set; }
    //    [Required]
    //    public string Name { get; set; }
    //    public Guid BrandId { get; set; }
    //    public Brand Brand { get; set; }
     [Key]
    public Guid ModelId { get; set; }

    [Required]
    [MaxLength(100)]
    public  string Name { get; set; }

 
    [ForeignKey(nameof(Brand))]
    public Guid BrandId { get; set; }

    public Brand Brand { get; set; }
}
}
