﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using animalrescue.mainmodule.dal;

#nullable disable

namespace animalrescue.mainmodule.dal.Migrations.SqliteMigrations
{
    [DbContext(typeof(LocalAnimalRescueContext))]
    [Migration("20221109021426_location_calendar")]
    partial class locationcalendar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11");

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Address2")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(55)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AnimalRescueAccount");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountAdoptionApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AnimalRescueAccountId");

                    b.ToTable("AnimalRescueAccountAdoptionApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountFosterApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AnimalRescueAccountId")
                        .IsUnique();

                    b.ToTable("AnimalRescueAccountFosterApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountLocation", b =>
                {
                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnimalRescueAccountId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("AnimalRescueAccountLocation");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountRole", b =>
                {
                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnimalRescueAccountId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AnimalRescueAccountRole");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountVolunteerApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalRescueAccountId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AnimalRescueAccountId")
                        .IsUnique();

                    b.ToTable("AnimalRescueAccountVolunteerApplication");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CalendarTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SerializedInfo")
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CalendarTypeId");

                    b.HasIndex("LocationId");

                    b.ToTable("Calendar");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.CalendarType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<int>("Name")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CalendarType");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CalendarId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Address2")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(55)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Role");
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

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccountVolunteerApplication", b =>
                {
                    b.HasOne("animalrescue.mainmodule.dal.models.AnimalRescueAccount", "AnimalRescueAccount")
                        .WithOne("AnimalRescueAccountVolunteerApplication")
                        .HasForeignKey("animalrescue.mainmodule.dal.models.AnimalRescueAccountVolunteerApplication", "AnimalRescueAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalRescueAccount");
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

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.AnimalRescueAccount", b =>
                {
                    b.Navigation("AnimalRescueAccountAdoptionApplications");

                    b.Navigation("AnimalRescueAccountFosterApplication")
                        .IsRequired();

                    b.Navigation("AnimalRescueAccountLocations");

                    b.Navigation("AnimalRescueAccountRoles");

                    b.Navigation("AnimalRescueAccountVolunteerApplication")
                        .IsRequired();
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

            modelBuilder.Entity("animalrescue.mainmodule.dal.models.Role", b =>
                {
                    b.Navigation("AnimalRescueAccountRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
