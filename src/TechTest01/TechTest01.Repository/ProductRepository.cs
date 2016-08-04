using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly IDbContext _context;
        private IDbSet<Product> _productDbSet;

        public ProductRepository(IDbContext context)
        {
            _context = context;
        }

        private IDbSet<Product> ProductDbSet
        {
            get { return _productDbSet ?? (_productDbSet = _context.Set<Product>()); }
        }

        public IQueryable<Product> GetAll()
        {
            return ProductDbSet.Select(p=>p);
        }

        public Product Get(int id)
        {
            return ProductDbSet.Where(e => e.Id == id).SingleOrDefault();
        }

        public Product Get(string slug)
        {
            return ProductDbSet.Where(e => e.Slug == slug).SingleOrDefault();
        }

        public void Insert(Product model)
        {
            throw new NotImplementedException();

            //if (model == null)
            //    throw new ArgumentNullException("model");

            //ProductDbSet.Add(model);

        }
        public void Update(Product model)
        {
            throw new NotImplementedException();

            //if (model == null)
            //    throw new ArgumentNullException("model");

            //_context.Entry(model).State = EntityState.Modified;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();

            //Product product = _entities.Find(id);
            //ProductDbSet.Remove(product);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

       
    }
}
