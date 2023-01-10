using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class ApplicationAgreement
    {
        public int Id {get; set;}
        public string Agreement {get; set;} = string.Empty;
        public virtual IEnumerable<VolunteerApplicationAgreement> VolunteerApplicationAgreements {get;set;} = null!;

    }
}