using System.ComponentModel.DataAnnotations;

namespace CarsRental.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public String? UserName { get; set; }
        public String? Password { get; set; }
        public String? Email { get; set; }
        public String? PhoneNumber { get; set; }
        public ICollection<Rent>? Rents { get; set; }
    }
}
