﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using animalrescue.mainmodule.dal;

#nullable disable

namespace animalrescue.mainmodule.dal.Migrations.SqlServerMigrations
{
    [DbContext(typeof(AnimalRescueContext))]
    partial class AnimalRescueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Address2")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("City")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Country")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("LastName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("AnimalRescueAccount");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountAdoptionApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimalRescueAccountId");

                    b.ToTable("AnimalRescueAccountAdoptionApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountFosterApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimalRescueAccountId")
                        .IsUnique();

                    b.ToTable("AnimalRescueAccountFosterApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountLocation", b =>
                {
                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("AnimalRescueAccountId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("AnimalRescueAccountLocation");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountRole", b =>
                {
                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("AnimalRescueAccountId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AnimalRescueAccountRole");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.ApplicationAgreement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Agreement")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationAgreement");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.ApplicationInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Interest")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationInterest");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.ApplicationPurpose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationPurpose");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalendarTypeId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("SerializedInfo")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CalendarTypeId");

                    b.HasIndex("LocationId");

                    b.ToTable("Calendar");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.CalendarType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CalendarType");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalendarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Address2")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("City")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Country")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.PetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeOfPet")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PetType");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Address2")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("int");

                    b.Property<string>("BottleFeedingDetails")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("City")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool?>("ConvictedFelonyOfAnimals")
                        .HasColumnType("bit");

                    b.Property<string>("ConvictedFelonyOfAnimalsDetails")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Country")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("DogTrainingDetails")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("GrantWritingDetails")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool?>("HaveBottleFeeding")
                        .HasColumnType("bit");

                    b.Property<bool?>("HaveDogTraining")
                        .HasColumnType("bit");

                    b.Property<bool?>("HaveGrantWriting")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool?>("OwnCat")
                        .HasColumnType("bit");

                    b.Property<bool?>("OwnDog")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalRescueAccountId")
                        .IsUnique();

                    b.ToTable("VolunteerApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplicationAgreement", b =>
                {
                    b.Property<int>("VolunteerApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationAgreementId")
                        .HasColumnType("int");

                    b.HasKey("VolunteerApplicationId", "ApplicationAgreementId");

                    b.HasIndex("ApplicationAgreementId");

                    b.ToTable("VolunteerApplicationAgreement");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplicationInterest", b =>
                {
                    b.Property<int>("VolunteerApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationInterestId")
                        .HasColumnType("int");

                    b.HasKey("VolunteerApplicationId", "ApplicationInterestId");

                    b.HasIndex("ApplicationInterestId");

                    b.ToTable("VolunteerApplicationInterest");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplicationPet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PetTypeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("VolunteerApplicationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetTypeId");

                    b.HasIndex("VolunteerApplicationId");

                    b.ToTable("VolunteerApplicationPet");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplicationPurpose", b =>
                {
                    b.Property<int>("VolunteerApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationPurposeId")
                        .HasColumnType("int");

                    b.HasKey("VolunteerApplicationId", "ApplicationPurposeId");

                    b.HasIndex("ApplicationPurposeId");

                    b.ToTable("VolunteerApplicationPurpose");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountAdoptionApplication", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.AnimalRescueAccount", "AnimalRescueAccount")
                        .WithMany("AnimalRescueAccountAdoptionApplications")
                        .HasForeignKey("AnimalRescueAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalRescueAccount");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountFosterApplication", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.AnimalRescueAccount", "AnimalRescueAccount")
                        .WithOne("AnimalRescueAccountFosterApplication")
                        .HasForeignKey("animalrescue.mainmodule.dal.models.AnimalRescueAccountFosterApplication", "AnimalRescueAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalRescueAccount");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountLocation", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.AnimalRescueAccount", "AnimalRescueAccount")
                        .WithMany("AnimalRescueAccountLocations")
                        .HasForeignKey("AnimalRescueAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animalrescue.mainmodule.dal.models.Location", "Location")
                        .WithMany("AnimalRescueAccountLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalRescueAccount");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountRole", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.AnimalRescueAccount", "AnimalRescueAccount")
                        .WithMany("AnimalRescueAccountRoles")
                        .HasForeignKey("AnimalRescueAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animalrescue.mainmodule.dal.models.Role", "Role")
                        .WithMany("AnimalRescueAccountRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalRescueAccount");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Calendar", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.CalendarType", "CalendarType")
                        .WithMany("Calendars")
                        .HasForeignKey("CalendarTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animalrescue.mainmodule.dal.models.Location", "Location")
                        .WithMany("Calendars")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalendarType");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Event", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.Calendar", "Calendar")
                        .WithMany("Events")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calendar");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplication", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.AnimalRescueAccount", "AnimalRescueAccount")
                        .WithOne("VolunteerApplication")
                        .HasForeignKey("animalrescue.mainmodule.dal.models.VolunteerApplication", "AnimalRescueAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalRescueAccount");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplicationAgreement", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.ApplicationAgreement", "ApplicationAgreement")
                        .WithMany("VolunteerApplicationAgreements")
                        .HasForeignKey("ApplicationAgreementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animalrescue.mainmodule.dal.models.VolunteerApplication", "VolunteerApplication")
                        .WithMany("VolunteerApplicationAgreements")
                        .HasForeignKey("VolunteerApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationAgreement");

                    b.Navigation("VolunteerApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplicationInterest", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.ApplicationInterest", "ApplicationInterest")
                        .WithMany("VolunteerApplicationInterests")
                        .HasForeignKey("ApplicationInterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animalrescue.mainmodule.dal.models.VolunteerApplication", "VolunteerApplication")
                        .WithMany("VolunteerApplicationInterests")
                        .HasForeignKey("VolunteerApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationInterest");

                    b.Navigation("VolunteerApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplicationPet", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.PetType", "PetType")
                        .WithMany("VolunteerApplicationPets")
                        .HasForeignKey("PetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animalrescue.mainmodule.dal.models.VolunteerApplication", "VolunteerApplication")
                        .WithMany("VolunteerApplicationPets")
                        .HasForeignKey("VolunteerApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PetType");

                    b.Navigation("VolunteerApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplicationPurpose", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.ApplicationPurpose", "ApplicationPurpose")
                        .WithMany("VolunteerApplicationPurposes")
                        .HasForeignKey("ApplicationPurposeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animalrescue.mainmodule.dal.models.VolunteerApplication", "VolunteerApplication")
                        .WithMany("VolunteerApplicationPurposes")
                        .HasForeignKey("VolunteerApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationPurpose");

                    b.Navigation("VolunteerApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccount", b =>
                {
                    b.Navigation("AnimalRescueAccountAdoptionApplications");

                    b.Navigation("AnimalRescueAccountFosterApplication")
                        .IsRequired();

                    b.Navigation("AnimalRescueAccountLocations");

                    b.Navigation("AnimalRescueAccountRoles");

                    b.Navigation("VolunteerApplication")
                        .IsRequired();
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.ApplicationAgreement", b =>
                {
                    b.Navigation("VolunteerApplicationAgreements");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.ApplicationInterest", b =>
                {
                    b.Navigation("VolunteerApplicationInterests");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.ApplicationPurpose", b =>
                {
                    b.Navigation("VolunteerApplicationPurposes");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Calendar", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.CalendarType", b =>
                {
                    b.Navigation("Calendars");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Location", b =>
                {
                    b.Navigation("AnimalRescueAccountLocations");

                    b.Navigation("Calendars");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.PetType", b =>
                {
                    b.Navigation("VolunteerApplicationPets");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Role", b =>
                {
                    b.Navigation("AnimalRescueAccountRoles");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.VolunteerApplication", b =>
                {
                    b.Navigation("VolunteerApplicationAgreements");

                    b.Navigation("VolunteerApplicationInterests");

                    b.Navigation("VolunteerApplicationPets");

                    b.Navigation("VolunteerApplicationPurposes");
                });
#pragma warning restore 612, 618
        }
    }
}
