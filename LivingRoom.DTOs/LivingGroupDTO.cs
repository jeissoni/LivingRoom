using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingRoom.DTOs
{
    public class LivingGroupDTO
    {
        public int IdLivingGroup { get; set; }

        public CityDTO City { get; set; }

        public string Address { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public Days Day { get; set; }

        public string Description { get; set; }

        public AttendeeLivingGroupDTO AttendeeLivingGroups { get; set; }
        public LeaderLivingGroupDTO LeaderLivingGroups { get; set; }

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
