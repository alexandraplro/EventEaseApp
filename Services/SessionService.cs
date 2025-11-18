namespace EventEaseApp.Services
{
    public class SessionService
    {
        public string? CurrentUserName { get; set; }
        public string? CurrentUserEmail { get; set; }

        // Optional: track registrations tied to this session
        public List<Models.Registration> UserRegistrations { get; } = new();
    }
}
