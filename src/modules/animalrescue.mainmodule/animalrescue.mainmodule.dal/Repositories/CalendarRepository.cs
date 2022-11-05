using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;

namespace animalrescue.mainmodule.dal.repositories
{
    public class CalendarRepository : BaseRepository<Calendar>, ICalendarRepository
    {
        public CalendarRepository(AnimalRescueContext animalRescueContext) : base(animalRescueContext)
        {
        }
    }
}