using animalrescue.mainmodule.dal.models;

namespace animalrescue.mainmodule.dal.repositories.interfaces
{
    public interface ILocationRepository
    {
<<<<<<< HEAD
        Task<int> CreateAsync(Location location);
        Task<Location?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(Location location, ICollection<string> modifiedProperties);
=======
        Task<int> Create(Location location);
>>>>>>> main
    }
}