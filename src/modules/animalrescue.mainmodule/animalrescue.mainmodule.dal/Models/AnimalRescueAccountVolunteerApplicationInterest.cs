using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class AnimalRescueAccountVolunteerApplicationInterest
    {
        public int Id {get; set;}
        public string? Interest {get; set;}
    }
}