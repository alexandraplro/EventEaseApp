using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class EventService
    {
        private readonly List<Event> _events = new()
        {
            new() { Name = "Summit of Strategy", Date = new DateTime(2026, 2, 12), Location = "Washington, DC", Description = "Executive summit on strategy, culture, and resilient leadership." },
            new() { Name = "Tech & Trust Expo", Date = new DateTime(2026, 3, 5), Location = "Austin, TX", Description = "Showcase of ethical AI, secure cloud, and human-centered digital design." },
            new() { Name = "Impact & Insight Forum", Date = new DateTime(2026, 4, 18), Location = "New York, NY", Description = "Data storytelling, impact measurement, and comms for social change." },
            new() { Name = "Creators Collective", Date = new DateTime(2026, 5, 9), Location = "San Francisco, CA", Description = "Design systems, accessibility, and product craft for modern web." },
            new() { Name = "Global Dev Exchange", Date = new DateTime(2026, 6, 21), Location = "Seattle, WA", Description = "Full-stack patterns, DevOps, and scalable cloud-native architectures." },
            new() { Name = "Community Catalyst", Date = new DateTime(2026, 7, 13), Location = "Chicago, IL", Description = "Grassroots organizing, civic tech, and inclusive event experiences." },
        };

        public IEnumerable<Event> GetEvents() => _events;

        public Event? GetByName(string name) =>
            _events.FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
