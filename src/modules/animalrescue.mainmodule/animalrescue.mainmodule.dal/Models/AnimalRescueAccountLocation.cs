using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class AnimalRescueAccountLocation
    {
        public int AnimalRescueAccountId {get;set;}
        public int LocationId {get;set;}
        public bool IsActive {get;set;}
        public virtual AnimalRescueAccount AnimalRescueAccount { get; set;} = null!;
        public virtual Location Location { get; set;} = null!;
    }
}