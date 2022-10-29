using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class Location
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public virtual IEnumerable<AnimalRescueAccountLocation> AnimalRescueAccountLocations {get; set;}
        public virtual IEnumerable<Calendar> Calendars {get; set;}
    }
}