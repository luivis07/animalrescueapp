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
            CreateMap<AnimalRescueAccountUpdateVm,AnimalRescueAccountDto>();
            CreateMap<AnimalRescueAccountDto,AnimalRescueAccountDetailsVm>();
        }
    }
}