using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivingRoom.Entities.POCOs
{
    public class AttendeeLivingGroup
    {

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Id")]
        public User User { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("IdLivingGroup")]
        public LivingGroup LivingGroup { get; set; }


    }
}
