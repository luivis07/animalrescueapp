using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class Pet
    {
        public int Id {get; set;}
        public int? PetTypeId {get;set;}
        public string? Breed {get; set;}
        public string? Sex {get;set;}
        public int? Age {get;set;}
        public virtual PetType PetType {get; set;} = null!;
    }
}