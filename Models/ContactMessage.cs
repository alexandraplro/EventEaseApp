using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class ContactMessage
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Comment is required")]
        [StringLength(200, ErrorMessage = "Comment cannot exceed 200 words")]
        public string Comment { get; set; } = string.Empty;
    }
}
