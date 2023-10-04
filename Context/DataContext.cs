using Crito.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crito.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ContactMessageEntity> ContactMessages { get; set; }

    }
}
