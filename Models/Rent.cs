using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsRental.Models
{
    public class Rent
    {
        [Key]
        public int RentId { get; set; }
        public String? Type { get; set; }
        public double? Amount { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public virtual User? User { get; set; }
        public int? CarId {get; set;}
        public Car? Car {get; set;}
    }
}
