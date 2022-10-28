using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal
{
    public class AnimalRescueContext : DbContext
    {
        protected readonly IConfiguration configuration;

        public DbSet<VolunteerApplication> VolunteerApplication {get; set;}
        public DbSet<AdoptionApplication> AdoptionApplication {get; set;}
        public DbSet<AnimalRescueAccount> AnimalRescueAccount {get; set;}
        public DbSet<AnimalRescueAccountAdoptionApplication> AnimalRescueAccountAdoptionApplication {get; set;}
        public DbSet<AnimalRescueAccountFosterApplication> AnimalRescueAccountFosterApplication {get; set;}
        public DbSet<AnimalRescueAccountLocation> AnimalRescueAccountLocation {get; set;}
        public DbSet<AnimalRescueAccountRole> AnimalRescueAccountRole {get; set;}
        public DbSet<AnimalRescueAccountVolunteerApplication> AnimalRescueAccountVolunteerApplication {get; set;}
        public DbSet<Calendar> Calendar {get; set;}
        public DbSet<CalendarType> CalendarType {get; set;}
        public DbSet<Event> Event {get; set;}
        public DbSet<Location> Location {get; set;}
        public DbSet<LocationCalendar> LocationCalendar {get; set;}
        public DbSet<Role> Role {get; set;}

        public AnimalRescueContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(configuration.GetConnectionString("animalrescuedb"));
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            AnimalRescueAccount
            */
            modelBuilder.Entity<AnimalRescueAccount>()
                .HasMany(ara => ara.AnimalRescueAccountRoles)
                .WithOne(arar => arar.AnimalRescueAccount)
                .HasForeignKey(ara => ara.AnimalRescueAccountId);

            modelBuilder.Entity<AnimalRescueAccount>()
                .HasMany(ara => ara.AnimalRescueAccountLocations)
                .WithOne(aral => aral.AnimalRescueAccount)
                .HasForeignKey(ara => ara.AnimalRescueAccountId);

            /*Role*/    
            modelBuilder.Entity<Role>()
                .HasMany(r => r.AnimalRescueAccountRoles)
                .WithOne(arar => arar.Role)
                .HasForeignKey(r => r.RoleId);

            /*Location*/    
            modelBuilder.Entity<Location>()
                .HasMany(l => l.AnimalRescueAccountLocations)
                .WithOne(aral => aral.Location)
                .HasForeignKey(l => l.LocationId);
            
            modelBuilder.Entity<Location>()
                .HasMany(l => l.LocationCalendars)
                .WithOne(lc => lc.Location)
                .HasForeignKey(l => l.LocationId);
            
            /*Calendar*/
            modelBuilder.Entity<Calendar>()
                .HasOne(c => c.CalendarType)
                .WithMany(ct => ct.Calendars)
                .HasForeignKey(c => c.CalendarTypeId);

            modelBuilder.Entity<Calendar>()
                .HasOne(c => c.LocationCalendar)
                .WithMany(lc => lc.Calendar)
                .HasForeignKey(c => c.Id);

            /*Event*/
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Calendar)
                .WithMany(c => c.Events)    
                .HasForeignKey(e => e.CalendarId);

            /*AnimalRescueAccountVolunteerApplication*/
            modelBuilder.Entity<AnimalRescueAccountVolunteerApplication>()
                .HasOne<AnimalRescueAccount>(aravp => aravp.AnimalRescueAccount)
                .WithOne(ara => ara.AnimalRescueAccountVolunteerApplication)
                .HasForeignKey<AnimalRescueAccountVolunteerApplication>(aravp => aravp.AnimalRescueAccountId);
            
            /*AnimalRescueAccountFosterApplication*/
            modelBuilder.Entity<AnimalRescueAccountFosterApplication>()
                .HasOne<AnimalRescueAccount>(arafp => arafp.AnimalRescueAccount)
                .WithOne(ara => ara.AnimalRescueAccountFosterApplication)
                .HasForeignKey<AnimalRescueAccountFosterApplication>(arafp => arafp.AnimalRescueAccountId);

            /*AnimalRescueAccountAdoptionApplication*/
            modelBuilder.Entity<AnimalRescueAccountAdoptionApplication>()
                .HasOne(araaa => araaa.AnimalRescueAccount)
                .WithMany(ara => ara.AnimalRescueAccountAdoptionApplications)
                .HasForeignKey(araaa => araaa.AnimalRescueAccountId);

            /*AnimalRescueAccountRole*/
            modelBuilder.Entity<AnimalRescueAccountRole>()
                .HasKey(arar => new{arar.AnimalRescueAccountId,arar.RoleId});
            
            /*AnimalRescueAccountLocation*/
            modelBuilder.Entity<AnimalRescueAccountLocation>()
                .HasKey(aral => new{aral.AnimalRescueAccountId,aral.LocationId});

            /*LocationCalendar*/
            modelBuilder.Entity<LocationCalendar>()
                .HasKey(lc => new{lc.LocationId,lc.CalendarId});

            base.OnModelCreating(modelBuilder);
        }
    }
}