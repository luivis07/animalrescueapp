using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;

namespace animalrescue.mainmodule.dal.repositories
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        private readonly AnimalRescueContext animalRescueContext;

        public LocationRepository(AnimalRescueContext animalRescueContext) : base(animalRescueContext)
        {
            this.animalRescueContext = animalRescueContext;
        }

        public async Task<int> Create(Location location)
        {
            dbSet.Add(location);
            await animalRescueContext.SaveChangesAsync();
            return location.Id;
        }
    }
}