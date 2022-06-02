using LivingRoom.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace LivingRoom.Repositoy.DataContext
{
    public class LivingRoomContext : DbContext
    {
        public LivingRoomContext(
            DbContextOptions<LivingRoomContext> options) 
            : base(options) { }

        public DbSet<User> Users { get; set; }
        
    }
}
