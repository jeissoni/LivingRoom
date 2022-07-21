using System.ComponentModel.DataAnnotations;

namespace LivingRoom.Entities.POCOs
{
    public class City
    {
        [Key]
        public int IdCity { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }

    }
}
