using AutoMapper;
using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.setup.mappings
{
    public class AnimalRescueAccountMap : Profile
    {
        public AnimalRescueAccountMap()
        {
            CreateMap<AnimalRescueAccount, AnimalRescueAccountDto>()
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());

            CreateMap<AnimalRescueAccountDto, AnimalRescueAccount>()
                .ForMember(dest => dest.AnimalRescueAccountRoles, o => o.Ignore())
                .ForMember(dest => dest.AnimalRescueAccountLocations, o => o.Ignore())
                .ForMember(dest => dest.AnimalRescueAccountVolunteerApplication, o => o.Ignore())
                .ForMember(dest => dest.AnimalRescueAccountFosterApplication, o => o.Ignore())
                .ForMember(dest => dest.AnimalRescueAccountAdoptionApplications, o => o.Ignore());
        }
    }
}