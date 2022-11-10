using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.handlers.interfaces
{
    public interface ILocationHandler
    {
<<<<<<< HEAD
        Task<int> CreateAsync(LocationDto locationDto);
        Task<LocationDto?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(LocationDto dto);
=======
        Task<int> Create(LocationDto locationDto);
>>>>>>> main
    }
}