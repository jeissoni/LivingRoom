using LivingRoom.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace LivingRoom.Repositoy.DataContext
{
    public class LivingRoomContext : DbContext
    {
        public LivingRoomContext(
            DbContextOptions<LivingRoomContext> options) 
            : base(options) { }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<UserAddress> UserAddresses { get; set; }  

        public DbSet<LivingGroup> LivingGroups { get; set; }

        public DbSet<LeaderLivingGroup> LeaderLivingGroups { get; set; }
        public DbSet<AttendeeLivingGroup> AttendeeLivingGroups { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //llave compuesta
        //    modelBuilder.Entity<AttendeeLivingGroup>()
        //        .HasKey(c => new { c.IdLivingGroup, c.User });
        //}
    }
}
