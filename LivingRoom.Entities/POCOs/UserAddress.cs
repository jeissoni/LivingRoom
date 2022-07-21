using System.ComponentModel.DataAnnotations;

namespace LivingRoom.Entities.POCOs
{
    public class UserAddress
    {
        [Key]
        public int UserAddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public  User User { get; set; }
    }
}
