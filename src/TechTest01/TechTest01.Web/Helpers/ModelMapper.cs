using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechTest01.Domain.Catalog;
using TechTest01.Web.Models;

namespace TechTest01.Web.Helpers
{
    public static class ModelMapper
    {

        public static ICollection<ProductVm> ToProductListViewModel(ICollection<Product> productListDm)
        {
            return productListDm.Select(ToProductViewModel).ToList();
        }

        public static ProductVm ToProductViewModel(Product productDm)
        {
            return new ProductVm
            {
                Id = productDm.Id,
                Name = productDm.Name,
                Description = productDm.Description,
                ImageUrl = productDm.ImageUrl,
                Price = productDm.Price,
                Slug = productDm.Slug
            };
        }

    }
}