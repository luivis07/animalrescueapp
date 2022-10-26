using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal
{
    public class AnimalRescueContext : DbContext
    {
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
    }
}