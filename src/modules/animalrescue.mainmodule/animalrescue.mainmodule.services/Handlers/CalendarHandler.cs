using animalrescue.mainmodule.services.handlers.interfaces;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;

namespace animalrescue.mainmodule.services.handlers
{
    public class CalendarHandler : BaseHandler, ICalendarHandler
    {
        public void Test()
        {
            var rrule = new RecurrencePattern(FrequencyType.Daily, 1) { Count = 5 };
            var e = new CalendarEvent
            {
                Start = new CalDateTime(DateTime.Now),
                End = new CalDateTime(DateTime.Now.AddHours(1)),
                RecurrenceRules = new List<RecurrencePattern> { rrule }
            };
            var calendar = new Calendar();
            calendar.Events.Add(e);

            var serializer = new CalendarSerializer();
            var serializedCalendar = serializer.SerializeToString(calendar);
        }
    }
}