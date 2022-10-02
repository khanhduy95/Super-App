using Microsoft.EntityFrameworkCore;
using SuperApp.Core.OrderFood;

namespace SuperApp.Core.DbContextweq
{
    public class SuppAppContext : DbContext
    {
        public SuppAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
    }
}
