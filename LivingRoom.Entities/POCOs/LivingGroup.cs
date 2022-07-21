using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivingRoom.Entities.POCOs
{
    public class LivingGroup
    {
        [Key]
        public int IdLivingGroup { get; set; }

        public virtual City City { get; set; }

        public string Address { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public Days Day { get; set; }

        public string Description { get; set; }

        public List<AttendeeLivingGroup> AttendeeLivingGroups { get; set; }
        public List<LeaderLivingGroup> LeaderLivingGroups { get; set; }

        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
