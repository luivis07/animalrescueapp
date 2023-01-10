using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class PetType
    {
        public int Id {get; set;}
        public string TypeOfPet {get;set;} = string.Empty;
        public virtual IEnumerable<VolunteerApplicationPet> VolunteerApplicationPets {get; set;} = null!;
    }
}