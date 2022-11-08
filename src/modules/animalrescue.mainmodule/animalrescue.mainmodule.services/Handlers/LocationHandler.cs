using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using AutoMapper;

namespace animalrescue.mainmodule.services.handlers
{
    public class LocationHandler : BaseHandler, ILocationHandler
    {
        private readonly ILocationRepository locationRepository;
        private readonly IMapper mapper;

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
        }
    }
}