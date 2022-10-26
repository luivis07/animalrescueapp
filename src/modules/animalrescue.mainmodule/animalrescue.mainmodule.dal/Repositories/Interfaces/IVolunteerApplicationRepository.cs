using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.repositories.interfaces
{
    public interface IVolunteerApplicationRepository
    {
        public IEnumerable<VolunteerApplication> GetVolunteerApplications();
    }
}