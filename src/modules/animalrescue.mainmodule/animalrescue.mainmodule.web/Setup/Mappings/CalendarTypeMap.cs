using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.web.viewmodels.calendartype;
using AutoMapper;

namespace animalrescue.mainmodule.web.mappings
{
    public class CalendarTypeMap : Profile
    {
        public CalendarTypeMap()
        {
            CreateMap<CalendarTypeCreateVm, CalendarTypeDto>()
                .ForMember(dest => dest.Id, o => o.Ignore())
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());

            CreateMap<CalendarTypeUpdateVm, CalendarTypeDto>()
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());
                
            CreateMap<CalendarTypeDto, CalendarTypeDetailsVm>();

            CreateMap<CalendarTypeUpdateVm, CalendarTypeDetailsVm>();
        }
    }
}