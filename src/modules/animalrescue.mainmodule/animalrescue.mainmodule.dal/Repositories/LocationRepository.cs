using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace animalrescue.mainmodule.dal.repositories
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        private readonly AnimalRescueContext animalRescueContext;

        public LocationRepository(AnimalRescueContext animalRescueContext) : base(animalRescueContext)
        {
            this.animalRescueContext = animalRescueContext;
        }

        public async Task<int> CreateAsync(Location location)
        {
            dbSet.Add(location);
            await animalRescueContext.SaveChangesAsync();
            return location.Id;
        }

        public async Task<IEnumerable<Location>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<Location?> GetByIdAsync(int id)
        {
            return await dbSet.SingleOrDefaultAsync(l => l.Id == id);
        }

        public async Task<bool> UpdateAsync(Location location, ICollection<string> modifiedProperties)
        {
            return await base.UpdateAsync(location, modifiedProperties);
        }
    }
}