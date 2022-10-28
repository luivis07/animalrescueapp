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
        public DbSet<AnimalRescueAccountRole> AnimalRescueAccountRole {get; set;}
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

            /*Role*/    
            modelBuilder.Entity<Role>()
                .HasMany(r => r.AnimalRescueAccountRoles)
                .WithOne(arar => arar.Role)
                .HasForeignKey(r => r.RoleId);
            /*AnimalRescueAccountRole*/
            modelBuilder.Entity<AnimalRescueAccountRole>()
                .HasKey(arar => new{arar.AnimalRescueAccountId,arar.RoleId});
            base.OnModelCreating(modelBuilder);
        }
    }
}