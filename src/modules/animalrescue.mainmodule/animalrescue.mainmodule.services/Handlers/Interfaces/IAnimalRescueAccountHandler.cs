using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.handlers.interfaces
{
    public interface IAnimalRescueAccountHandler
    {
        public Task<AnimalRescueAccountDto?> GetAnimalRescueAccountByUsername(string username);
    }
}