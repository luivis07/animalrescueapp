using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class AnimalRescueAccountRole
    {
        public int AnimalRescueAccountId {get;set;}
        public int RoleId {get;set;}
        public bool IsActive {get;set;}
        public virtual AnimalRescueAccount AnimalRescueAccount { get; set;} = null!;
        public virtual Role Role { get; set;} = null!;
    }
}