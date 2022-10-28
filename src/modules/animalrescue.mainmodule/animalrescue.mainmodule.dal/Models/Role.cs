using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class Role
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public virtual IEnumerable<AnimalRescueAccountRole> AnimalRescueAccountRoles {get; set;}
    }
}