using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class TechTestDbContext : DbContext, IDbContext
    {

        public TechTestDbContext() : base("TechTestContext")
        {
        }

        public DbSet<Product> Products { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
