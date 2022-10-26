using AutoMapper;
using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.setup.mappings
{
    public class VolunteerApplicationMap : Profile
    {
        public VolunteerApplicationMap()
        {
            CreateMap<VolunteerApplication, VolunteerApplicationDto>();    
        }
    }
}