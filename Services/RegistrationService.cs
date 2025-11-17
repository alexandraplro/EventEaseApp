using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public static class RegistrationService
    {
        private static readonly List<Registration> registrations = new();

        public static void AddRegistration(Registration reg)
        {
            registrations.Add(reg);
        }

        public static List<Registration> GetRegistrations()
        {
            return registrations;
        }
    }
}
