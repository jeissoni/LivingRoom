using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingRoom.Repositoy.DataContext
{
    public class LivingRoomContext : DbContext
    {
        public LivingRoomContext(
            DbContextOptions<LivingRoomContext> options) : base(options) { }
        
    }
}
