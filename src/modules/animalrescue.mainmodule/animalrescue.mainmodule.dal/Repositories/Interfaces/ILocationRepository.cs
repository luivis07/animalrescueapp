using animalrescue.mainmodule.dal.models;

namespace animalrescue.mainmodule.dal.repositories.interfaces
{
    public interface ILocationRepository
    {
        Task<int> Create(Location location);
    }
}