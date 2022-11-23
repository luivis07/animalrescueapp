using animalrescue.mainmodule.helpers.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class VolunteerApplicationPet : Pet, IhasPetCharacteristics
    {
        public int VolunteerApplicationId {get;set;}
        public virtual VolunteerApplication VolunteerApplication { get; set;} = null!;
    }
}