using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class AnimalRescueAccountAdoptionApplication
    {
        public int Id {get; set;}
        public int AnimalRescueAccountId {get; set;}
        public virtual AnimalRescueAccount AnimalRescueAccount {get; set;}
    }
}