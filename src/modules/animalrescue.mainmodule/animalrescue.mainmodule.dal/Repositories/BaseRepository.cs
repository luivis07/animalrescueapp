using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        private readonly AnimalRescueContext animalRescueContext;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(AnimalRescueContext animalRescueContext)
        {
            this.animalRescueContext = animalRescueContext;
            this.dbSet = animalRescueContext.Set<T>();
        }
        protected async Task<bool> UpdateAsync(T entity, ICollection<string> modifiedProperties, bool saveChanges = true)
        {
            var entry = animalRescueContext.Entry(entity);
            foreach(var property in modifiedProperties)
            {
                entry.Property(property).IsModified = true;
            }
            if(saveChanges)
                return await animalRescueContext.SaveChangesAsync() > 0;
            return true;
        }
    }
}