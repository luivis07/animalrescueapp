using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using AutoMapper;
<<<<<<< HEAD
using FluentValidation;
using FluentValidation.Results;
=======
>>>>>>> main

namespace animalrescue.mainmodule.services.handlers
{
    public class LocationHandler : BaseHandler, ILocationHandler
    {
        private readonly ILocationRepository locationRepository;
        private readonly IMapper mapper;
<<<<<<< HEAD
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
=======

        public LocationHandler(ILocationRepository locationRepository,
            IMapper mapper)
        {
            this.locationRepository = locationRepository;
            this.mapper = mapper;
        }
        public async Task<int> Create(LocationDto locationDto)
        {
            var location = mapper.Map<Location>(locationDto);
            return await locationRepository.Create(location);
>>>>>>> main
        }
    }
}