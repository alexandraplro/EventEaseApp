namespace EventEaseApp.Models
{
    public class Event
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;

        // NEW: Description property
        public string Description { get; set; } = string.Empty;
    }
}


