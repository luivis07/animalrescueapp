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

        public int Create(AnimalRescueAccount animalRescueAccount)
        {
            dbSet.Add(animalRescueAccount);
            animalRescueContext.SaveChanges();
            return animalRescueAccount.Id;
        }

        public async Task<int> CreateAsync(AnimalRescueAccount animalRescueAccount)
        {
            dbSet.Add(animalRescueAccount);
            await animalRescueContext.SaveChangesAsync();
            return animalRescueAccount.Id;
        }

        public async Task<AnimalRescueAccount?> GetByIdAsync(int id)
        {
            return await dbSet.FirstOrDefaultAsync(ara => ara.Id == id);
        }

        public async Task<AnimalRescueAccount?> GetByUsernameAsync(string username)
        {
            return await dbSet.FirstOrDefaultAsync(ara => ara.Username == username);
        }
        
        public async Task<bool> UpdateAsync(AnimalRescueAccount animalRescueAccount, ICollection<string> modifiedProperties)
        {
            return await base.UpdateAsync(animalRescueAccount, modifiedProperties);
        }
    }
}