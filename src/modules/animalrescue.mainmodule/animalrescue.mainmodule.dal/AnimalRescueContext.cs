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
        public DbSet<AnimalRescueAccount> AnimalRescueAccount => Set<AnimalRescueAccount>();
        public DbSet<AnimalRescueAccountAdoptionApplication> AnimalRescueAccountAdoptionApplication => Set<AnimalRescueAccountAdoptionApplication>();
        public DbSet<AnimalRescueAccountFosterApplication> AnimalRescueAccountFosterApplication => Set<AnimalRescueAccountFosterApplication>();
        public DbSet<AnimalRescueAccountLocation> AnimalRescueAccountLocation => Set<AnimalRescueAccountLocation>();
        public DbSet<AnimalRescueAccountRole> AnimalRescueAccountRole => Set<AnimalRescueAccountRole>();
        public DbSet<AnimalRescueAccountVolunteerApplication> AnimalRescueAccountVolunteerApplication => Set<AnimalRescueAccountVolunteerApplication>();
        public DbSet<Calendar> Calendar => Set<Calendar>();
        public DbSet<CalendarType> CalendarType => Set<CalendarType>();
        public DbSet<Event> Event => Set<Event>();
        public DbSet<Location> Location => Set<Location>();
        public DbSet<Role> Role => Set<Role>();

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