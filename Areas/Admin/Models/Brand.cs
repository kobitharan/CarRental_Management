using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Car_Rental_Management_System.Areas.Admin.Models
{
  public class Brand
   {
        //        public Guid Id { get; set; }
        //        public string Name { get; set; }
        //        public List<Model> Models { get; set; }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Model> Models { get; set; } = new List<Model>();

    }
}
