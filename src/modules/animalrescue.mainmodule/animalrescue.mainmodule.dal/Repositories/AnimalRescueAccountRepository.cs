using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.repositories
{
    public class AnimalRescueAccountRepository : BaseRepository<AnimalRescueAccount> , IAnimalRescueAccountRepository
    {
        private readonly AnimalRescueContext animalRescueContext;

        public AnimalRescueAccountRepository(AnimalRescueContext animalRescueContext) : base(animalRescueContext)
        {
            this.animalRescueContext = animalRescueContext;
        }

        public async Task<AnimalRescueAccount?> GetById(int id)
        {
            return await animalRescueContext.AnimalRescueAccount.FirstOrDefaultAsync(ara => ara.Id == id);
        }

        public async Task<AnimalRescueAccount?> GetByUsername(string username)
        {
            return await animalRescueContext.AnimalRescueAccount.FirstOrDefaultAsync(ara => ara.Username == username);
        }

        public async Task<bool> Update(AnimalRescueAccount animalRescueAccount, ICollection<string> modifiedProperties)
        {
            return await UpdateAsync(animalRescueAccount,modifiedProperties);
        }
    }
}