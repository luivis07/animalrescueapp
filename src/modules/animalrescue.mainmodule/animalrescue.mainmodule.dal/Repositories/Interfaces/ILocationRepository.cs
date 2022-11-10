using animalrescue.mainmodule.dal.models;

namespace animalrescue.mainmodule.dal.repositories.interfaces
{
    public interface ILocationRepository
    {
        Task<int> CreateAsync(Location location);
        Task<IEnumerable<Location>> GetAllAsync();
        Task<Location?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(Location location, ICollection<string> modifiedProperties);
    }
}