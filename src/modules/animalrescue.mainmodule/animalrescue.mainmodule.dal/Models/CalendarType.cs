using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class CalendarType
    {
        public int Id {get; set;}
        public int Name {get; set;}
        public bool IsActive { get; set; }
        public virtual IEnumerable<Calendar> Calendars {get; set;} = null!;
    }
}