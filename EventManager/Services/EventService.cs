public class EventService
{
    private List<EventModel> events = new()
    {
        new EventModel { Id = 1, Name = "Tech Conference", Date = DateTime.Now.AddDays(10), Location = "Cairo", Description = "A conference for technology enthusiasts." },
        new EventModel { Id = 2, Name = "Music Fest", Date = DateTime.Now.AddMonths(1), Location = "Alexandria", Description = "A festival of live music performances." }
    };

    public List<EventModel> GetEvents() => events;
    public EventModel GetEventById(int id)
    {
        if (id >= 0 && id <= events.Count)
        {
            return events.FirstOrDefault(e => e.Id == id);
        }
        else
        {
            throw new ArgumentException("Invalid event ID");
        }
    }
}