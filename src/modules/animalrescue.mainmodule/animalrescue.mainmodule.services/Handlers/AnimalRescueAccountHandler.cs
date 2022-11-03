using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;

namespace animalrescue.mainmodule.services.handlers
{
    public class AnimalRescueAccountHandler : IAnimalRescueAccountHandler
    {
        private readonly IAnimalRescueAccountRepository animalRescueAccountRepository;
        private readonly IMapper mapper;
        private readonly IValidator<AnimalRescueAccountDto> validator;

        public AnimalRescueAccountHandler(IAnimalRescueAccountRepository animalRescueAccountRepository,
                                            IMapper mapper,
                                            IValidator<AnimalRescueAccountDto> validator)
        {
            this.animalRescueAccountRepository = animalRescueAccountRepository;
            this.mapper = mapper;
            this.validator = validator;
        }

        public async Task<int> CreateAsync(AnimalRescueAccountDto animalRescueAccountDto)
        {
            var animalRescueAccount = mapper.Map<AnimalRescueAccount>(animalRescueAccountDto);
            var newId = await animalRescueAccountRepository.CreateAsync(animalRescueAccount);
            return newId;
        }

        public int Create(AnimalRescueAccountDto animalRescueAccountDto)
        {
            var animalRescueAccount = mapper.Map<AnimalRescueAccount>(animalRescueAccountDto);
            var newId = animalRescueAccountRepository.Create(animalRescueAccount);
            return newId;
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
            var result = validator.Validate(animalRescueAccountDto);
            var temp = mapper.Map<AnimalRescueAccount>(animalRescueAccountDto);
            return await animalRescueAccountRepository.UpdateAsync(temp,animalRescueAccountDto.ChangedProperties.ToList());
        }
    }
}