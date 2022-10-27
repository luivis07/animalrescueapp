using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using Microsoft.Extensions.Configuration;
=======
>>>>>>> main
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal
{
    public class AnimalRescueContext : DbContext
    {
<<<<<<< HEAD
        protected readonly IConfiguration configuration;

        public DbSet<VolunteerApplication> VolunteerApplications {get; set;}
        public DbSet<AdoptionApplication> AdoptionApplications {get; set;}

        public AnimalRescueContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(configuration.GetConnectionString("animalrescuedb"));
=======
        public DbSet<VolunteerApplication> VolunteerApplications {get; set;}
        public DbSet<AdoptionApplication> AdoptionApplications {get; set;}

        public string DbPath {get;}
        public AnimalRescueContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "animalrescue.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
>>>>>>> main
    }
}