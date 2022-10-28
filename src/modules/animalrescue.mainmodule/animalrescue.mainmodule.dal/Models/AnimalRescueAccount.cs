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
        public virtual AnimalRescueAccountVolunteerApplication AnimalRescueAccountVolunteerApplication { get; set; } 
        public virtual AnimalRescueAccountFosterApplication AnimalRescueAccountFosterApplication { get; set; }  
        public virtual IEnumerable<AnimalRescueAccountAdoptionApplication> AnimalRescueAccountAdoptionApplications { get; set; }   
    }
}