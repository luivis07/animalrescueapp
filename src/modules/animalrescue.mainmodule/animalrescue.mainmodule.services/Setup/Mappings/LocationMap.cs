using AutoMapper;
using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.setup.mappings
{
    public class LocationMap : Profile
    {
        public LocationMap()
        {
            CreateMap<Location, LocationDto>()
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());

            CreateMap<LocationDto, Location>()
                .ForMember(dest => dest.AnimalRescueAccountLocations, o => o.Ignore())
                .ForMember(dest => dest.Calendars, o => o.Ignore());
        }
    }
}