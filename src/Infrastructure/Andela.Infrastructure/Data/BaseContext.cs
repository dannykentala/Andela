using Andela.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Andela.Infrastructure.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        { }

        // Dangerus: Now infrastructure is jumping to first layer
        public DbSet<Student> Students {get; set;}
    }
}