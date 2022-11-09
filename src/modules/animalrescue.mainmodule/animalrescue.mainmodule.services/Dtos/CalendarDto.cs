using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace animalrescue.mainmodule.services.dtos
{
    public class CalendarDto : BaseDto
    {
        public int Id {get; set;}
        public int CalendarTypeId {get;set;}
        public int LocationId {get;set;}
        public string? SerializedInfo { get; set; }
    }
}