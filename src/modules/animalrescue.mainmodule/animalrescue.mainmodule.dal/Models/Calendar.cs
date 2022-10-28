using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class Calendar
    {
        public int Id {get; set;}
        public int CalendarTypeId {get;set;}
        public virtual CalendarType CalendarType {get; set;}
        public virtual LocationCalendar LocationCalendar {get; set;}
        public virtual IEnumerable<Event> Events {get;set;}
    }
}