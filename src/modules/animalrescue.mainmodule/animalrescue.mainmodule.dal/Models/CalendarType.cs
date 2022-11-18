using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class CalendarType
    {
        public int Id {get; set;}
        public string Name {get; set;} = string.Empty;
        public bool IsActive { get; set; }
        public virtual IEnumerable<Calendar> Calendars {get; set;} = null!;
    }
}