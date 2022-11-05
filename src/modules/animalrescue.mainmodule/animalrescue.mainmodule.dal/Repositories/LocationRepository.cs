using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;

namespace animalrescue.mainmodule.dal.repositories
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        public LocationRepository(AnimalRescueContext animalRescueContext) : base(animalRescueContext)
        {
        }
    }
}