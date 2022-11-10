using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.handlers.interfaces
{
    public interface ICalendarTypeHandler
    {
        Task<int> CreateAsync(CalendarTypeDto calendarTypeDto);
        Task<CalendarTypeDto?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(CalendarTypeDto dto);
    }
}