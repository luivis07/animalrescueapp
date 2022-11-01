using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.handlers.interfaces
{
    public interface IAnimalRescueAccountHandler
    {
        public Task<AnimalRescueAccountDto?> GetByUsername(string username);
        public Task<bool> Update(AnimalRescueAccountDto animalRescueAccountDto);
    }
}