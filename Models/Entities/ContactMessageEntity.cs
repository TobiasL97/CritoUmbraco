using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entities
{
    public class ContactMessageEntity
    {
        public string Name { get; set; } = null!;

        [Key]
        public string Email { get; set; } = null!;

        public string Message { get; set; } = null!;
    }
}
