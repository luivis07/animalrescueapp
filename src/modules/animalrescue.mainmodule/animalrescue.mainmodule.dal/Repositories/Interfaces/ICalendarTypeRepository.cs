using animalrescue.mainmodule.dal.models;

namespace animalrescue.mainmodule.dal.repositories.interfaces
{
    public interface ICalendarTypeRepository
    {
        Task<int> CreateAsync(CalendarType calendarType);
        Task<CalendarType?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(CalendarType calendarType, ICollection<string> modifiedProperties);
    }
}