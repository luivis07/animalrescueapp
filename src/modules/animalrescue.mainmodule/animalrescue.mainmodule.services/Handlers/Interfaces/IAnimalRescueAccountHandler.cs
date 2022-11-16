using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.handlers.interfaces
{
    public interface IAnimalRescueAccountHandler
    {
        public Task<AnimalRescueAccountDto?> GetByUsernameAsync(string username);
        public AnimalRescueAccountDto? GetByUsername(string username);
        public Task<bool> UpdateAsync(AnimalRescueAccountDto animalRescueAccountDto);
        public Task<AnimalRescueAccountDto?> GetByIdAsync(int id);
        public Task<int> CreateAsync(AnimalRescueAccountDto animalRescueAccountDto);
        public int Create(AnimalRescueAccountDto animalRescueAccountDto);
    }
}