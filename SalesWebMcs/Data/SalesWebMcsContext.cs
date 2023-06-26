using Microsoft.EntityFrameworkCore;
using SalesWebMcs.Models;

namespace SalesWebMcs.Data
{
    public class SalesWebMcsContext : DbContext
    {
        public SalesWebMcsContext (DbContextOptions<SalesWebMcsContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
