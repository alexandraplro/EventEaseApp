using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class EventService
    {
        private readonly List<Event> _events = new()
        {
            new Event
            {
                Name = "Tech Horizons Summit",
                Date = new DateTime(2026, 3, 15),
                Location = "Seattle, WA",
                Description = "A forward-looking conference exploring AI, cloud, and future innovations in software development."
            },
            new Event
            {
                Name = "Global Culture Fest",
                Date = new DateTime(2026, 7, 22),
                Location = "Bogotá, Colombia",
                Description = "A vibrant celebration of food, music, and traditions from around the world — family friendly!"
            },
            new Event
            {
                Name = "Wellness Weekend Retreat",
                Date = new DateTime(2026, 10, 10),
                Location = "Asheville, NC",
                Description = "Relax and recharge with yoga, meditation, and workshops on holistic health and mindfulness."
            },
            new Event
            {
                Name = "Innovation Hackathon",
                Date = new DateTime(2026, 5, 5),
                Location = "Boston, MA",
                Description = "A 48-hour hackathon where teams build creative solutions to real-world problems."
            },
            new Event
            {
                Name = "Art in the Park",
                Date = new DateTime(2026, 6, 12),
                Location = "Chicago, IL",
                Description = "An outdoor festival showcasing local artists, live music, and food trucks."
            },
            new Event
            {
                Name = "Future of Health Expo",
                Date = new DateTime(2026, 9, 18),
                Location = "San Francisco, CA",
                Description = "Exploring innovations in digital health, biotech, and wellness technology."
            }
        };

        public IEnumerable<Event> GetEvents() => _events;
    }
}
