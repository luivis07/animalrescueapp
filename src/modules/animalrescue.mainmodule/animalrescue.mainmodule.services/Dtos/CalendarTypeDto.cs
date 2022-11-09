using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace animalrescue.mainmodule.services.dtos
{
    public class CalendarTypeDto : BaseDto
    {
        public int Id {get; set;}
        public int Name {get; set;}
        public bool IsActive { get; set; }
    }
}