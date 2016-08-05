using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain;
using TechTest01.Domain.Catalog;


namespace TechTest01.Services.Catalog
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepos;

        public ProductService(IProductRepository productRepos)
        {
            _productRepos = productRepos;
        }

        public Product GetById(int id)
        {
            return _productRepos.Get(id);
        }

        public Product GetBySlug(string slug)
        {
            return _productRepos.Get(slug);
        }

        public ICollection<Product> GetProducts()
        {
            return _productRepos.GetAll().ToList();
        }

        public ICollection<Product> GetRandomProducts()
        {
            var prods = new List<Product>();
            int totalCount = _productRepos.GetAll().Count();
            var prodQuery = _productRepos.GetAll().OrderBy(p=>p.Id);

            Random rnd = new Random();

            var pos1 = rnd.Next(0, totalCount-1);
            prods.Add(prodQuery.Skip(pos1).First());
            int pos2 = rnd.Next(0, totalCount-1);
            
            // dont return the same product
            if (pos2 == pos1)
            {
                if (pos2 == 0)
                {
                    pos2++;
                }
                else
                {
                    pos2--;
                }
            }
            prods.Add(prodQuery.Skip(pos2).First());


            return prods;
        }
    }
}
