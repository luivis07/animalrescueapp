using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class VolunteerApplicationPurpose
    {
        public int VolunteerApplicationId {get;set;}
        public int ApplicationPurposeId {get;set;}
        public virtual VolunteerApplication VolunteerApplication { get; set;} = null!;
        public virtual ApplicationPurpose ApplicationPurpose { get; set;} = null!;
    }
}