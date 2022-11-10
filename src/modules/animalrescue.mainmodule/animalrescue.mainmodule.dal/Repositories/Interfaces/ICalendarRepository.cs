using animalrescue.mainmodule.dal.models;

namespace animalrescue.mainmodule.dal.repositories.interfaces
{
    public interface ICalendarRepository
    {
        Task<int> CreateAsync(Calendar calendar);
        Task<Calendar?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(Calendar calendar, ICollection<string> modifiedProperties);
    }
}