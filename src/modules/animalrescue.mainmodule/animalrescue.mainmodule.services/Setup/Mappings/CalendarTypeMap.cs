using AutoMapper;
using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.setup.mappings
{
    public class CalendarTypeMap : Profile
    {
        public CalendarTypeMap()
        {
            CreateMap<CalendarType, CalendarTypeDto>()
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());

            CreateMap<CalendarTypeDto, CalendarType>()
                .ForMember(dest => dest.Calendars, o => o.Ignore());
        }
    }
}