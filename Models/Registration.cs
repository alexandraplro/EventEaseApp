using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Event selection is required")]
        public string? EventName { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }
    }
}
