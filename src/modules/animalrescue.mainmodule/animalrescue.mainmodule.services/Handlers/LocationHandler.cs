using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;

namespace animalrescue.mainmodule.services.handlers
{
    public class LocationHandler : BaseHandler, ILocationHandler
    {
        private readonly ILocationRepository locationRepository;
        private readonly IMapper mapper;
        private readonly IValidator<LocationDto> validator;
        private readonly ValidationResult validationResult;

        public LocationHandler(ILocationRepository locationRepository,
            IMapper mapper, 
            IValidator<LocationDto> validator, 
            ValidationResult validationResult)
        {
            this.locationRepository = locationRepository;
            this.mapper = mapper;
            this.validator = validator;
            this.validationResult = validationResult;
        }
        public async Task<int> CreateAsync(LocationDto locationDto)
        {
            var location = mapper.Map<Location>(locationDto);
            return await locationRepository.CreateAsync(location);
        }

        public async Task<IEnumerable<LocationDto>> GetAllAsync()
        {
            var locations = await locationRepository.GetAllAsync();
            return mapper.Map<IEnumerable<LocationDto>>(locations);
        }

        public async Task<LocationDto?> GetByIdAsync(int id)
        {
            var location = await locationRepository.GetByIdAsync(id);
            return mapper.Map<LocationDto?>(location);
        }

        public async Task<bool> UpdateAsync(LocationDto dto)
        {
            var result = validator.Validate(dto);
            if (!result.IsValid)
            {
                mapper.Map(result, validationResult);
                return false;
            }
            var temp = mapper.Map<Location>(dto);
            return await locationRepository.UpdateAsync(temp, dto.ChangedProperties.ToList());
        }
    }
}