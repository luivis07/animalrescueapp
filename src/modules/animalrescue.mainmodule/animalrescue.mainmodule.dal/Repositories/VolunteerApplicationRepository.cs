using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.repositories
{
    public class VolunteerApplicationRepository : BaseRepository<VolunteerApplication>, IVolunteerApplicationRepository
    {
        private readonly AnimalRescueContext animalRescueContext;

        public VolunteerApplicationRepository(AnimalRescueContext animalRescueContext)
        {
            this.animalRescueContext = animalRescueContext;
        }

        public IEnumerable<VolunteerApplication> GetVolunteerApplications()
        {
            return animalRescueContext.VolunteerApplication.ToList();
        }
    }
}