using AutoMapper;
using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.setup.mappings
{
    public class CalendarMap : Profile
    {
        public CalendarMap()
        {
            CreateMap<Calendar, CalendarDto>()
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());

            CreateMap<CalendarDto, Calendar>()  
                .ForMember(dest => dest.CalendarType, o => o.Ignore())
                .ForMember(dest => dest.Events, o => o.Ignore())
                .ForMember(dest => dest.Location, o => o.Ignore());
        }
    }
}
