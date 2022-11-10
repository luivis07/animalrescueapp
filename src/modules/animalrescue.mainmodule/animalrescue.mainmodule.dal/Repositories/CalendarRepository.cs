using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace animalrescue.mainmodule.dal.repositories
{
    public class CalendarRepository : BaseRepository<Calendar>, ICalendarRepository
    {
        private readonly AnimalRescueContext animalRescueContext;

        public CalendarRepository(AnimalRescueContext animalRescueContext) : base(animalRescueContext)
        {
            this.animalRescueContext = animalRescueContext;
        }

        public async Task<int> CreateAsync(Calendar calendar)
        {
            dbSet.Add(calendar);
            await animalRescueContext.SaveChangesAsync();
            return calendar.Id;
        }

        public async Task<Calendar?> GetByIdAsync(int id)
        {
            return await dbSet.SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> UpdateAsync(Calendar calendar, ICollection<string> modifiedProperties)
        {
            return await base.UpdateAsync(calendar, modifiedProperties);
        }
    }
}