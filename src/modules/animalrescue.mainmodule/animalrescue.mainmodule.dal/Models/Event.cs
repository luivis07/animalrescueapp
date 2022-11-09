using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class Event
    {
        public int Id {get; set;}
        public int CalendarId {get; set;}
        public Calendar Calendar {get; set;} = null!;
    }
}