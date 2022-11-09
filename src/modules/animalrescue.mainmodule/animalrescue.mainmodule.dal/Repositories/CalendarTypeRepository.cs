using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;

namespace animalrescue.mainmodule.dal.repositories
{
    public class CalendarTypeRepository : BaseRepository<CalendarType>, ICalendarTypeRepository
    {
        public CalendarTypeRepository(AnimalRescueContext animalRescueContext) : base(animalRescueContext)
        {
        }
    }
}