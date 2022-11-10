using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.setup;
using animalrescue.mainmodule.web.viewmodels.animalrescueaccount;
using animalrescue.mainmodule.web.viewmodels.calendar;
using AutoMapper;

namespace animalrescue.mainmodule.web.mappings
{
    public class CalendarMap : Profile
    {
        public CalendarMap()
        {
            CreateMap<CalendarCreateVm, CalendarDto>()
                .ForMember(dest => dest.Id, o => o.Ignore())
                .ForMember(dest => dest.SerializedInfo, o => o.Ignore())
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());

            CreateMap<CalendarUpdateVm, CalendarDto>()
                .ForMember(dest => dest.SerializedInfo, o => o.Ignore())
                .ForMember(dest => dest.ChangedProperties, o => o.Ignore());
                
            CreateMap<CalendarDto, CalendarDetailsVm>()
                .ForMember(dest => dest.CalendarTypes, o => o.Ignore())
                .ForMember(dest => dest.CalendarTypesDropdown, o => o.Ignore())
                .ForMember(dest => dest.Locations, o => o.Ignore())
                .ForMember(dest => dest.LocationsDropdown, o => o.Ignore());

            CreateMap<CalendarUpdateVm, CalendarDetailsVm>();
        }
    }
}