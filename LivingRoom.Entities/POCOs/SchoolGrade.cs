using System.ComponentModel.DataAnnotations;

namespace LivingRoom.Entities.POCOs
{
    public class SchoolGrade
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public User User { get; set; }
    }
}
