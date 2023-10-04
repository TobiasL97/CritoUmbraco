using Crito.Context;
using Crito.Models;
using Crito.Models.Entities;

namespace Crito.Services
{
    public class ContactFormService
    {
        private readonly DataContext _context;

        public ContactFormService(DataContext context)
        {
            _context = context;
        }

        public async Task AddContactMessage(ContactForm contactform)
        {
            _context.ContactMessages.Add(new ContactMessageEntity
            {
                Name = contactform.Name,
                Email = contactform.Email,
                Message = contactform.Message,
            });

            await _context.SaveChangesAsync();
        }
    }
}
