using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.repositories
{
    public class AnimalRescueAccountRepository : IAnimalRescueAccountRepository
    {
        private readonly AnimalRescueContext animalRescueContext;

        public AnimalRescueAccountRepository(AnimalRescueContext animalRescueContext)
        {
            this.animalRescueContext = animalRescueContext;
        }

        public async Task<AnimalRescueAccount?> GetByUsername(string username)
        {
            return await animalRescueContext.AnimalRescueAccount.FirstOrDefaultAsync(ara => ara.Username == username);
        }

        public async Task<bool> Update(AnimalRescueAccount animalRescueAccount)
        {
            animalRescueContext.AnimalRescueAccount.Update(animalRescueAccount);
            var result = await animalRescueContext.SaveChangesAsync();
            return result>0;
        }
    }
}