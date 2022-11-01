using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual IEnumerable<AnimalRescueAccountLocation> AnimalRescueAccountLocations { get; set; } = null!;
        public virtual IEnumerable<Calendar> Calendars { get; set; } = null!;
    }
}