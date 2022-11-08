using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.handlers.interfaces
{
    public interface ILocationHandler
    {
        Task<int> Create(LocationDto locationDto);
    }
}