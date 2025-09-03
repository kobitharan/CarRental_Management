using Car_Rental_Management_System.Areas.Admin.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Management_System.Areas.Customer.Models
{
    public class Favourite
    {
        //public Guid FavouriteId { get; set; }
        //public Guid CustomerId { get; set; }
        //public Guid CarId { get; set; }

        //public CustomerUser CustomerUser { get; set; }
        //public Car Car { get; set; }

        [Key]
        public Guid FavouriteId { get; set; }

      
        [ForeignKey(nameof(CustomerUser))]
        public Guid CustomerId { get; set; }
        public CustomerUser CustomerUser { get; set; }

        [ForeignKey(nameof(Car))]
        public Guid CarId { get; set; }

      

        public Car Car { get; set; }
    }
}
