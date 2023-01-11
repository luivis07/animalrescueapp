namespace animalrescue.mainmodule.web.apimodels
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public int CalendarId { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}