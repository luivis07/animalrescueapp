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

        public async Task<AnimalRescueAccountDto?> GetAnimalRescueAccountByUsername(string username)
        {
            var temp = await animalRescueAccountRepository.GetAnimalRescueAccountByUsername(username);
            return mapper.Map<AnimalRescueAccountDto?>(temp);
        }
    }
}