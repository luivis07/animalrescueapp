using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class VolunteerApplicationAgreement
    {
        public int VolunteerApplicationId {get;set;}
        public int ApplicationAgreementId {get;set;}
        public virtual VolunteerApplication VolunteerApplication { get; set;} = null!;
        public virtual ApplicationAgreement ApplicationAgreement { get; set;} = null!;
    }
}