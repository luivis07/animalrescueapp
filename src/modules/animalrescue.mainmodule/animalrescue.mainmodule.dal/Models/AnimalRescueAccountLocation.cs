using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    [Index(nameof(Location),nameof(AnimalRescueAccount),IsUnique =true)]
    public class AnimalRescueAccountLocation
    {
        public int AnimalRescueAccountId {get;set;}
        public int LocationId {get;set;}
        public bool IsActive {get;set;}
        public virtual AnimalRescueAccount AnimalRescueAccount { get; set;}
        public virtual Location Location { get; set;}
    }
}