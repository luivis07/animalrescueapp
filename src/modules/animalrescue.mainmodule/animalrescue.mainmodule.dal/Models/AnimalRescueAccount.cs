using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class AnimalRescueAccount
    {
        public int Id {get; set;}
        public string Username {get; set;}
        public string FirstName {get; set;}
        public virtual IEnumerable<AnimalRescueAccountRole> AnimalRescueAccountRoles {get; set;}
        public virtual IEnumerable<AnimalRescueAccountLocation> AnimalRescueAccountLocations {get; set;}
    }
}