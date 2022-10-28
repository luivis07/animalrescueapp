using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class LocationCalendar
    {
        public int LocationId {get;set;}
        public int CalendarId {get;set;}
        public bool IsActive {get;set;}
        public virtual Location Location { get; set;}
        public virtual IEnumerable<Calendar> Calendar { get; set;}
    }
}