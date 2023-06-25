using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
