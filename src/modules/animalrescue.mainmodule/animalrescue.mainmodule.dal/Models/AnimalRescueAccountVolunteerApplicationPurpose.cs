using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class AnimalRescueAccountVolunteerApplicationPurpose
    {
        public int AnimalRescueAccountVolunteerApplicationId {get;set;}
        public int ApplicationPurposeId {get;set;}
        public virtual AnimalRescueAccountVolunteerApplication AnimalRescueAccountVolunteerApplication { get; set;} = null!;
        public virtual ApplicationPurpose ApplicationPurpose { get; set;} = null!;
    }
}