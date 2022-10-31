using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.repositories.interfaces
{
    public interface IAnimalRescueAccountRepository
    {
        public Task<AnimalRescueAccount?> GetAnimalRescueAccountByUsername(string username);
    }
}