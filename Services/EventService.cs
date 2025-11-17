using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public static class EventService
    {
        private static readonly List<Event> events = new()
        {
            new Event { Name = "Tech Summit 2025", Date = new DateTime(2025, 12, 5), Location = "Washington, DC" },
            new Event { Name = "Global Dev Conference", Date = new DateTime(2026, 1, 20), Location = "New York, NY" },
            new Event { Name = "AI & Ethics Forum", Date = new DateTime(2026, 3, 15), Location = "Boston, MA" }
        };

        public static List<Event> GetEvents() => events;

        public static Event? GetEventByName(string? name) =>
            events.FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
