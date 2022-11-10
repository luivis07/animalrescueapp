using animalrescue.mainmodule.services.dtos;

namespace animalrescue.mainmodule.services.handlers.interfaces
{
    public interface ICalendarHandler
    {
        Task<int> CreateAsync(CalendarDto calendarDto);
        Task<CalendarDto?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(CalendarDto dto);
    }
}