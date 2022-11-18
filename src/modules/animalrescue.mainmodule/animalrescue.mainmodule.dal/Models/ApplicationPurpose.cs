using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class ApplicationPurpose
    {
        public int Id {get; set;}
        public string Purpose {get; set;} = string.Empty;
        public virtual IEnumerable<VolunteerApplicationPurpose> VolunteerApplicationPurposes {get;set;} = null!;

    }
}