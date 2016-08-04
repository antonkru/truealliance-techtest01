using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    class TechTestDbInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<TechTestDbContext>
    {
        protected override void Seed(TechTestDbContext context)
        {
            var products = new List<Product>
            {
            new Product{Slug="t-shirt", Description="T-Shirt", ImageUrl="t-shirt1.png", Name="T-Shirt", Price = 15.99M},
            new Product{Slug="abc-jacket", Description="It's a Jacket", ImageUrl="jacket10.png", Name="Abc jacket", Price = 55.99M},
            new Product{Slug="mens-xyz-jacket", Description="It's another Jacket", ImageUrl="jacket1.png", Name="Mens Xyz Jacket", Price = 45.99M},
            new Product{Slug="abc-sports-shorts", Description="There are shorts", ImageUrl="shorts1.png", Name="ABC Sports Shorts", Price = 38.99M},
            new Product{Slug="abc-t-shirt", Description="It's a tshirt", ImageUrl="t-shirt2.png", Name="Abc T-Shirt", Price = 20.99M},
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            
        }
    }
}
