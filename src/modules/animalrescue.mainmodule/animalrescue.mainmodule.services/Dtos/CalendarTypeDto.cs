using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PropertyChanged;

namespace animalrescue.mainmodule.services.dtos
{
    public class CalendarTypeDto : BaseDto
    {
        [DoNotNotify]
        public int Id {get; set;}
        public string Name {get; set;} = string.Empty;
        public bool IsActive { get; set; }
    }
}