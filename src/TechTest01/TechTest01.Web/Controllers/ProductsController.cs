using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services;
using TechTest01.Services.Catalog;
using TechTest01.Web.Helpers;
using TechTest01.Web.Models;

namespace TechTest01.Web.Controllers
{
    public class ProductsController : BaseController
    {
        public ProductsController(IProductService productService, ILogManager logManager) : base(productService, logManager)
        {
        }


        // GET: Products
        public ActionResult Index()
        {
            LogManager.LogInfo("Lets log something here");
            var viewModel = ModelMapper.ToProductListViewModel(ProductService.GetProducts());
            return View(viewModel);
        }

        public ActionResult RandomProductsPartial()
        {
            var viewModel = ModelMapper.ToProductListViewModel(ProductService.GetRandomProducts());
            return PartialView("partial/ProductList", viewModel);
        }

        public ActionResult Details(string slug)
        {
            if (string.IsNullOrEmpty(slug))
                throw new ArgumentException("Missing parameter", slug);

            var product = ProductService.GetBySlug(slug);
            if (product == null)
            {
                LogManager.LogInfoFormat("Product {0} does not exist", slug);
                throw new ApplicationException ("Product does not exist");
            }

            ProductVm viewModel = ModelMapper.ToProductViewModel(product);
            return View(viewModel);
        }

    }
}