using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.web.helpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace animalrescue.mainmodule.web.viewmodels.calendar
{
    public class CalendarUpdateVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CalendarTypeId {get;set;}
        public int LocationId {get;set;}
        public IEnumerable<CalendarTypeDto> CalendarTypes {get; set;} = new List<CalendarTypeDto>();
        public ICollection<SelectListItem> CalendarTypesDropdown => CalendarTypes.Select(ct => 
                new SelectListItem {
                    Value = ct.Id.ToString(),
                    Text = ct.Name
            }).ToList().AddDefaultItem().ToList();
        public IEnumerable<LocationDto> Locations {get; set;} = new List<LocationDto>();
        public ICollection<SelectListItem> LocationsDropdown => Locations.Select(ct => 
                new SelectListItem {
                    Value = ct.Id.ToString(),
                    Text = ct.Name
            }).ToList().AddDefaultItem().ToList();
    }
}