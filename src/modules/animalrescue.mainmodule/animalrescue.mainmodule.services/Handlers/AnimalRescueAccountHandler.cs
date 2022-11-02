using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using AutoMapper;

namespace animalrescue.mainmodule.services.handlers
{
    public class AnimalRescueAccountHandler : IAnimalRescueAccountHandler
    {
        private readonly IAnimalRescueAccountRepository animalRescueAccountRepository;
        private readonly IMapper mapper;

        public AnimalRescueAccountHandler(IAnimalRescueAccountRepository animalRescueAccountRepository,
                                            IMapper mapper)
        {
            this.animalRescueAccountRepository = animalRescueAccountRepository;
            this.mapper = mapper;
        }

        public async Task<AnimalRescueAccountDto?> GetByIdAsync(int id)
        {
            var animalRescueAccount = await animalRescueAccountRepository.GetByIdAsync(id);
            return mapper.Map<AnimalRescueAccountDto?>(animalRescueAccount);
        }

        public async Task<AnimalRescueAccountDto?> GetByUsernameAsync(string username)
        {
            var temp = await animalRescueAccountRepository.GetByUsernameAsync(username);
            return mapper.Map<AnimalRescueAccountDto?>(temp);
        }

        public async Task<bool> UpdateAsync(AnimalRescueAccountDto animalRescueAccountDto)
        {
            var temp = mapper.Map<AnimalRescueAccount>(animalRescueAccountDto);
            return await animalRescueAccountRepository.UpdateAsync(temp,animalRescueAccountDto.ChangedProperties.ToList());
        }
    }
}