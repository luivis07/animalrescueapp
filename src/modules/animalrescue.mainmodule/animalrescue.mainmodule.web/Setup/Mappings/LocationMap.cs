using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.web.viewmodels.location;
using AutoMapper;

namespace animalrescue.mainmodule.web.mappings
{
    public class LocationMap : Profile
    {
        public LocationMap()
        {
            CreateMap<LocationCreateVm, LocationDto>()
                .ForMember(dest => dest.Id, o => o.Ignore())
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());
        }
    }
}