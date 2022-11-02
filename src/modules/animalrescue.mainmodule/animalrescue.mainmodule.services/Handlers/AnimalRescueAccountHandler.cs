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

        public async Task<AnimalRescueAccountDto?> GetById(int id)
        {
            var animalRescueAccount = await animalRescueAccountRepository.GetById(id);
            return mapper.Map<AnimalRescueAccountDto?>(animalRescueAccount);
        }

        public async Task<AnimalRescueAccountDto?> GetByUsername(string username)
        {
            var temp = await animalRescueAccountRepository.GetByUsername(username);
            return mapper.Map<AnimalRescueAccountDto?>(temp);
        }

        public async Task<bool> Update(AnimalRescueAccountDto animalRescueAccountDto)
        {
            var temp = mapper.Map<AnimalRescueAccount>(animalRescueAccountDto);
            return await animalRescueAccountRepository.Update(temp,animalRescueAccountDto.ChangedProperties.ToList());
        }
    }
}