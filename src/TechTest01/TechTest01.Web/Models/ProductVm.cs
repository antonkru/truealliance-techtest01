using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechTest01.Web.Models
{
    public class ProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; } // this is the (sanitized) seo name for the product (e.g. /t-shirt)
        public string Description { get; set; }
        public decimal Price { get; set; }

        [UIHint("ProductImage")]
        public string ImageUrl { get; set; }


    }
}