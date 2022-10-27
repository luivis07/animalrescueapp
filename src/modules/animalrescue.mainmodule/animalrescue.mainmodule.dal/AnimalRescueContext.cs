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

        public DbSet<VolunteerApplication> VolunteerApplications {get; set;}
        public DbSet<AdoptionApplication> AdoptionApplications {get; set;}

        public AnimalRescueContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(configuration.GetConnectionString("animalrescuedb"));
    }
}