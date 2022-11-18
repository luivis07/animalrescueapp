using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class ApplicationInterest
    {
        public int Id {get; set;}
        public string Interest {get; set;} = string.Empty;
        public virtual IEnumerable<AnimalRescueAccountVolunteerApplicationInterest> AnimalRescueAccountVolunteerApplicationInterests {get;set;} = null!;

    }
}