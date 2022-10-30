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
        public DbSet<Role> Role {get; set;}

        public AnimalRescueContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(configuration.GetConnectionString("animalrescuedb"));
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnimalRescueContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}