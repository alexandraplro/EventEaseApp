using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class RegistrationService
    {
        private readonly List<Registration> _registrations = new();

        public IEnumerable<Registration> GetRegistrations() => _registrations;

        public void AddRegistration(Registration registration)
        {
            if (string.IsNullOrWhiteSpace(registration.Name)) return;
            if (string.IsNullOrWhiteSpace(registration.Email)) return;
            if (string.IsNullOrWhiteSpace(registration.EventName)) return;

            _registrations.Add(registration);
        }
        public void RemoveRegistration(Registration registration)
        {
            _registrations.Remove(registration);
        }
    }
}

