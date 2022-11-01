using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class AnimalRescueAccount
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public virtual IEnumerable<AnimalRescueAccountRole> AnimalRescueAccountRoles { get; set; } = null!;
        public virtual IEnumerable<AnimalRescueAccountLocation> AnimalRescueAccountLocations { get; set; } = null!;
        public virtual AnimalRescueAccountVolunteerApplication AnimalRescueAccountVolunteerApplication { get; set; } = null!;
        public virtual AnimalRescueAccountFosterApplication AnimalRescueAccountFosterApplication { get; set; } = null!;
        public virtual IEnumerable<AnimalRescueAccountAdoptionApplication> AnimalRescueAccountAdoptionApplications { get; set; } = null!;
    }
}