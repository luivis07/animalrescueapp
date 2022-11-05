using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.setup;
using animalrescue.mainmodule.web.viewmodels.animalrescueaccount;
using AutoMapper;

namespace animalrescue.mainmodule.web.mappings
{
    public class AnimalRescueAccountDtoMap : Profile
    {
        public AnimalRescueAccountDtoMap()
        {
            CreateMap<AnimalRescueAccountUpdateVm,AnimalRescueAccountDto>()
                .ForMember(dest => dest.Username, o => o.Ignore())
                .ForMember(dest => dest.EmailAddress, o => o.Ignore())
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());

            CreateMap<AnimalRescueAccountDto,AnimalRescueAccountDetailsVm>();
                
            CreateMap<AnimalRescueAccountUpdateVm,AnimalRescueAccountDetailsVm>()
                .ForMember(dest => dest.Username, o => o.Ignore())
                .ForMember(dest => dest.EmailAddress, o => o.Ignore());
        }
    }
}