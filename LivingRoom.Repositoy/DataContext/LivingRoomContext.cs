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
        public DbSet<UserAddress> UserAddresses { get; set; }  
        public DbSet<LivingGroup> LivingGroups { get; set; }
        public DbSet<SchoolGrade> SchoolGrade { get; set; }
        public DbSet<Segmentation> Segmentations { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<User> Users { get; set; }

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

            modelBuilder.Entity<City>()
               .HasKey(x => x.Id);

            modelBuilder.Entity<Country>()
               .HasKey(x => x.Id);



            //lave foranea de uno a muchos 
            //un usuario muchas direcciones
            //se inicia desde la entidad (*)
            modelBuilder.Entity<User>()
                .HasOne(a => a.UserAddress)
                .WithMany(u => u.Users)
                .HasForeignKey(a => a.UserAddressForeignKey);

            modelBuilder.Entity<User>()
                .HasOne(a => a.LivingGroup)
                .WithMany(u => u.Users)
                .HasForeignKey(x=>x.LivingGroupForeignKey);

            modelBuilder.Entity<City>()
               .HasOne(c => c.Country)
               .WithMany(c => c.City)
               .HasForeignKey(c => c.CountryForeignKey);



            modelBuilder.Entity<SchoolGrade>()
               .HasOne(a => a.User)
               .WithOne(u => u.SchoolGrade)
               .HasForeignKey<User>(x=>x.SchoolGradeForeignKey);

            modelBuilder.Entity<Segmentation>()
             .HasOne(a => a.User)
             .WithOne(u => u.Segmentation)
             .HasForeignKey<User>(x => x.SegmentationForeignKey);

            modelBuilder.Entity<Occupation>()
               .HasOne(a => a.User)
               .WithOne(x=> x.Occupation)
               .HasForeignKey<User>(x => x.OccupationForeignKey);

        }
    }
}
