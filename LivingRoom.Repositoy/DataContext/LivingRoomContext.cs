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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<UserAddress>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Segmentation>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<SchoolGrade>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Occupation>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<LivingGroup>()
                .HasKey(x => x.Id);       


            //lave foranea de uno a muchos 
            //un usuario muchas direcciones
            //se inicia desde la entidad (*)
            modelBuilder.Entity<UserAddress>()
                .HasMany(a => a.Users)
                .WithOne(u => u.UserAddress);

            modelBuilder.Entity<LivingGroup>()
                .HasMany(a => a.Users)
                .WithOne(u => u.UserLivingGroup);

            modelBuilder.Entity<Country>()
               .HasMany(a => a.City)
               .WithOne(u => u.Country);

            modelBuilder.Entity<Occupation>()
               .HasOne(a => a.User)
               .WithOne(u => u.Occupation);

            modelBuilder.Entity<SchoolGrade>()
               .HasOne(a => a.User)
               .WithOne(u => u.SchoolGrade);

            modelBuilder.Entity<Segmentation>()
             .HasOne(a => a.User)
             .WithOne(u => u.Segmentation);


        }
    }
}
