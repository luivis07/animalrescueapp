using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.handlers.interfaces
{
    public interface ILocationHandler
    {
        Task<int> CreateAsync(LocationDto locationDto);
        Task<LocationDto?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(LocationDto dto);
        Task<IEnumerable<LocationDto>> GetAllAsync();
    }
}