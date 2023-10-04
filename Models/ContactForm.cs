using System.ComponentModel.DataAnnotations;

namespace Crito.Models
{
    public class ContactForm
    {
        
        [Required(ErrorMessage = "Your name is required")]
        public string Name { get; set; } = null!;

        [Required (ErrorMessage = "Your Email is required")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required (ErrorMessage = "You need to enter a message")]
        public string Message { get; set; } = null!;

        public string RedirectUrl { get; set; } = "/";
    }
}
