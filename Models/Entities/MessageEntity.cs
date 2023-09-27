using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entities
{
    public class MessageEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Email { get; set; } = null!;

        public string Message { get; set; } = null!;

        
    }
}
