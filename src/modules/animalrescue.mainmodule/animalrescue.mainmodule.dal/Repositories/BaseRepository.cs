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
        protected async Task<bool> BaseUpdateAsync(T entity, ICollection<string> modifiedProperties)
        {
            var entry = animalRescueContext.Entry(entity);
            foreach(var property in modifiedProperties)
            {
                entry.Property(property).IsModified = true;
            }
            return await animalRescueContext.SaveChangesAsync() > 0;
        }
    }
}