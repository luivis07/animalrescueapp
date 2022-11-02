using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.repositories.interfaces
{
    public interface IAnimalRescueAccountRepository
    {
        public Task<AnimalRescueAccount?> GetByUsernameAsync(string username);
        public Task<bool> UpdateAsync(AnimalRescueAccount animalRescueAccount,ICollection<string> modifiedProperties);
        public Task<AnimalRescueAccount?> GetByIdAsync(int id);
    }
}