using animalrescue.mainmodule.helpers.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class Location : IHasAddress
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public virtual IEnumerable<AnimalRescueAccountLocation> AnimalRescueAccountLocations { get; set; } = null!;
        public virtual IEnumerable<Calendar> Calendars { get; set; } = null!;
    }
}