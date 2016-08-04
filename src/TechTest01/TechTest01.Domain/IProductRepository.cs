using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Domain
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
