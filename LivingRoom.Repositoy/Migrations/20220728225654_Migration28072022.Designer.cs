// <auto-generated />
using System;
using LivingRoom.Repositoy.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LivingRoom.Repositoy.Migrations
{
    [DbContext(typeof(LivingRoomContext))]
    [Migration("20220728225654_Migration28072022")]
    partial class Migration28072022
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LivingRoom.Entities.POCOs.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryForeignKey")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CountryForeignKey");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.LivingGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("Day")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaxAge")
                        .HasColumnType("integer");

                    b.Property<int>("MinAge")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("LivingGroups");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.Occupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Occupations");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.SchoolGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SchoolGrade");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.Segmentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Segmentations");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Attendee")
                        .HasColumnType("boolean");

                    b.Property<int>("CellPhoneNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int[]>("DaysAvailable")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<int?>("IdUser")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("Leader")
                        .HasColumnType("boolean");

                    b.Property<int>("LivingGroupForeignKey")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfChildren")
                        .HasColumnType("integer");

                    b.Property<int>("OccupationForeignKey")
                        .HasColumnType("integer");

                    b.Property<int>("SchoolGradeForeignKey")
                        .HasColumnType("integer");

                    b.Property<int>("SegmentationForeignKey")
                        .HasColumnType("integer");

                    b.Property<bool>("Sons")
                        .HasColumnType("boolean");

                    b.Property<bool>("Support")
                        .HasColumnType("boolean");

                    b.Property<int>("UserAddressForeignKey")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LivingGroupForeignKey");

                    b.HasIndex("OccupationForeignKey")
                        .IsUnique();

                    b.HasIndex("SchoolGradeForeignKey")
                        .IsUnique();

                    b.HasIndex("SegmentationForeignKey")
                        .IsUnique();

                    b.HasIndex("UserAddressForeignKey");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.City", b =>
                {
                    b.HasOne("LivingRoom.Entities.POCOs.Country", "Country")
                        .WithMany("City")
                        .HasForeignKey("CountryForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.LivingGroup", b =>
                {
                    b.HasOne("LivingRoom.Entities.POCOs.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.User", b =>
                {
                    b.HasOne("LivingRoom.Entities.POCOs.LivingGroup", "LivingGroup")
                        .WithMany("Users")
                        .HasForeignKey("LivingGroupForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LivingRoom.Entities.POCOs.Occupation", "Occupation")
                        .WithOne("User")
                        .HasForeignKey("LivingRoom.Entities.POCOs.User", "OccupationForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LivingRoom.Entities.POCOs.SchoolGrade", "SchoolGrade")
                        .WithOne("User")
                        .HasForeignKey("LivingRoom.Entities.POCOs.User", "SchoolGradeForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LivingRoom.Entities.POCOs.Segmentation", "Segmentation")
                        .WithOne("User")
                        .HasForeignKey("LivingRoom.Entities.POCOs.User", "SegmentationForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LivingRoom.Entities.POCOs.UserAddress", "UserAddress")
                        .WithMany("Users")
                        .HasForeignKey("UserAddressForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LivingGroup");

                    b.Navigation("Occupation");

                    b.Navigation("SchoolGrade");

                    b.Navigation("Segmentation");

                    b.Navigation("UserAddress");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.UserAddress", b =>
                {
                    b.HasOne("LivingRoom.Entities.POCOs.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.Country", b =>
                {
                    b.Navigation("City");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.LivingGroup", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.Occupation", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.SchoolGrade", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.Segmentation", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("LivingRoom.Entities.POCOs.UserAddress", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
