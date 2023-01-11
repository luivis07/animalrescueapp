using Microsoft.AspNetCore.Authorization;
using animalrescue.mainmodule.web.apimodels;
using Microsoft.AspNetCore.Mvc;

namespace animalrescue.mainmodule.web.controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class CalendarEventController : ControllerBase
    {
        public CalendarEventController()
        {
            
        }
        [HttpGet]
        public ActionResult<IEnumerable<CalendarEvent>> GetAllEvents()
        {
            var events = new List<CalendarEvent>();
            for(var i = 1; i <= 5; i++)
            {
                var ce = new CalendarEvent
                {
                    Id = i,
                    CalendarId = 1,
                    Title = $"Event {i}",
                    Category = "Test",
                    Start = DateTime.Now.AddDays(i),
                    End = DateTime.Now.AddHours(1)
                };
                events.Add(ce);
            }
            return events;
        }
    }
}