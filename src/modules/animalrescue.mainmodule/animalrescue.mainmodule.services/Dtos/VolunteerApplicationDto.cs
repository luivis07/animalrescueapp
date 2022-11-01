using System;
using System.Collections.Generic;
using System.ComponentModel;
using PropertyChanged;

namespace animalrescue.mainmodule.services.dtos
{
    public class VolunteerApplicationDto : BaseDto
    {
        [DoNotNotify]
        public int Id {get; set;}
    }
}