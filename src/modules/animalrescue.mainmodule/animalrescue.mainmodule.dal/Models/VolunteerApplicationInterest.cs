using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class VolunteerApplicationInterest
    {
        public int VolunteerApplicationId {get;set;}
        public int ApplicationInterestId {get;set;}
        public virtual VolunteerApplication VolunteerApplication { get; set;} = null!;
        public virtual ApplicationInterest ApplicationInterest { get; set;} = null!;
    }
}