using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.repositories.interfaces
{
    public interface IAnimalRescueAccountRepository
    {
        public Task<AnimalRescueAccount?> GetByUsername(string username);
        public Task<bool> Update(AnimalRescueAccount animalRescueAccount,ICollection<string> modifiedProperties);
        public Task<AnimalRescueAccount?> GetById(int id);
    }
}