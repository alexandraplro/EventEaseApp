using EventEaseApp.Models;
using System.Collections.Generic;

namespace EventEaseApp.Services
{
    public class RegistrationService
    {
        private readonly List<Registration> registrations = new();

        // Expose registrations as read-only to prevent accidental modification outside the service
        public IReadOnlyList<Registration> Registrations => registrations;

        // Add a new registration
        public void AddRegistration(Registration reg)
        {
            registrations.Add(reg);
        }

        // Optional: clear all registrations (useful for testing or reset)
        public void ClearRegistrations()
        {
            registrations.Clear();
        }
    }
}