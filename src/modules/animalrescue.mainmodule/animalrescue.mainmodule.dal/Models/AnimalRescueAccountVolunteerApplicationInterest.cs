using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class AnimalRescueAccountVolunteerApplicationInterest
    {
        public int AnimalRescueAccountVolunteerApplicationId {get;set;}
        public int ApplicationInterestId {get;set;}
        public virtual AnimalRescueAccountVolunteerApplication AnimalRescueAccountVolunteerApplication { get; set;} = null!;
        public virtual ApplicationInterest ApplicationInterest { get; set;} = null!;
    }
}