using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace animalrescue.mainmodule.dal.repositories
{
    public class CalendarTypeRepository : BaseRepository<CalendarType>, ICalendarTypeRepository
    {
        private readonly AnimalRescueContext animalRescueContext;

        public CalendarTypeRepository(AnimalRescueContext animalRescueContext) : base(animalRescueContext)
        {
            this.animalRescueContext = animalRescueContext;
        }

        public async Task<int> CreateAsync(CalendarType calendarType)
        {
            dbSet.Add(calendarType);
            await animalRescueContext.SaveChangesAsync();
            return calendarType.Id;
        }

        public async Task<CalendarType?> GetByIdAsync(int id)
        {
            return await dbSet.SingleOrDefaultAsync(ct => ct.Id == id);
        }

        public async Task<bool> UpdateAsync(CalendarType calendarType, ICollection<string> modifiedProperties)
        {
            return await base.UpdateAsync(calendarType, modifiedProperties);
        }
    }
}